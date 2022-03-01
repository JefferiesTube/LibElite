using Flurl;
using Flurl.Http;
using LibElite.EDSM.Types;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibElite.Helper;
using Newtonsoft.Json.Linq;

namespace LibElite.EDSM
{
    public static class EDSM
    {
        public static string BaseUrl = @"https://www.edsm.net/";
        public static int ThrottleDelay = 1;
        public static int ShortTimeout = 3;
        public static int LongTimeout = 10;
        public static int MaxTimeout = 30;

        public static async Task<SystemInfo> GetEstimatedValue(string systemName, bool throttleRequest = false)
        {
            try
            {
                SystemInfo sysInfo = await (BaseUrl + "api-system-v1/estimated-value")
                    .SetQueryParams(new { systemName })
                    .WithTimeout(ShortTimeout)
                    .GetJsonAsync<SystemInfo>();
                if (throttleRequest)
                    await Task.Delay(new TimeSpan(0, 0, ThrottleDelay));
                return sysInfo.IsValid() ? sysInfo : null;
            }
            catch (Exception e)
            {
                Logging.Logging.Error($"ESDM::GetEstimatedValue : {e.Message}", string.Join(Environment.NewLine, e.StackTrace));
                return null;
            }

        }

        public static async Task<Coords> GetSystemCoords(string systemName, bool throttleRequest = false)
        {
            try
            {
                string result = await (BaseUrl + "api-v1/system")
                    .SetQueryParams(new { systemName, showCoordinates = 1 })
                    .WithTimeout(ShortTimeout)
                    .GetStringAsync();
                if (throttleRequest)
                    await Task.Delay(new TimeSpan(0, 0, ThrottleDelay));
                JObject jobj = JObject.Parse(result);
                return jobj.ContainsKey("coords") ? jobj["coords"].ToObject<Coords>() : null;
            }
            catch (Exception e)
            {
                Logging.Logging.Error($"ESDM::GetSystemCoords : {e.Message}", string.Join(Environment.NewLine, e.StackTrace));
                return null;
            }
        }

        public static async Task<List<NearbySystems>> GetSystemsInSphere(string systemName, int min, int max, bool throttleRequest = false)
        {
            List<NearbySystems> systems = new List<NearbySystems>();
            try
            {
                NearbySystems[] sphereSystems = await (BaseUrl + "api-v1/sphere-systems")
                    .SetQueryParams(new
                    {
                    systemName, minRadius = min, radius = max, showCoordinates = 1
                    })
                    .WithTimeout(MaxTimeout)
                    .GetJsonAsync<NearbySystems[]>();
                systems = sphereSystems.ToList();
                systems.Remove(systems.FirstOrDefault(n => n.Name.Equals(systemName, StringComparison.InvariantCultureIgnoreCase)));
            }
            catch (Exception e)
            {
                Logging.Logging.Error($"ESDM::GetSystemsInSphere : {e.Message}", string.Join(Environment.NewLine, e.StackTrace));
            }
            if (throttleRequest)
                await Task.Delay(new TimeSpan(0, 0, ThrottleDelay));
            return systems;
        }

        public static async Task<SystemDetailInfo> GetSystemDetailInfo(string sysName, bool throttleRequest = false)
        {
            try
            {
                if (throttleRequest)
                    await Task.Delay(new TimeSpan(0, 0, ThrottleDelay));
                return await (BaseUrl + "api-v1/system").SetQueryParams(new
                {
                    systemName = sysName,
                    showId = 1,
                    showCoordinates = 1,
                    showPermit = 1,
                    showInformation = 1,
                    showPrimaryStar = 1
                })
                    .WithTimeout(LongTimeout)
                    .GetJsonAsync<SystemDetailInfo>();
            }
            catch (Exception e)
            {
                Logging.Logging.Error($"ESDM::GetSystemsInSphere : {e.Message}", string.Join(Environment.NewLine, e.StackTrace));
                return null;
            }
        }

        public static async Task<SystemBodies> GetSystemBodies(string systemName, bool throttleRequest = false)
        {
            try
            {
                SystemBodies sysInfo = await (BaseUrl + "api-system-v1/bodies")
                    .SetQueryParams(new { systemName })
                    .WithTimeout(LongTimeout)
                    .GetJsonAsync<SystemBodies>();
                if (throttleRequest)
                    await Task.Delay(new TimeSpan(0, 0, ThrottleDelay));
                return sysInfo.Id > 0 ? sysInfo : null;
            }
            catch
            {
                return null;
            }
        }

        public static async Task<SystemDeaths> GetSystemDeaths(string systemName, bool throttleRequest = false)
        {
            try
            {
                SystemDeaths systemDeaths = await (BaseUrl + "api-system-v1/deaths")
                    .SetQueryParams(new { systemName })
                    .WithTimeout(LongTimeout)
                    .GetJsonAsync<SystemDeaths>();
                if (throttleRequest)
                    await Task.Delay(new TimeSpan(0, 0, ThrottleDelay));
                return systemDeaths.Id > 0 ? systemDeaths : null;
            }
            catch
            {
                return null;
            }
        }

        public static async Task<SalesInfo> FindTradingRoute(long originId, int cargoCapacity, float jumpDistance, long budget, int speed)
        {
            string marketUrl = BaseUrl + "api-system-v1/stations/market";
            string sphereUrl = BaseUrl + "api-v1/sphere-systems";
            string stationsUrl = BaseUrl + "api-system-v1/stations";

            //Finds the market and system the search starts at
            string data = await marketUrl.SetQueryParam("marketId", originId).GetStringAsync();
            MarketInfo originMarket = JsonConvert.DeserializeObject<MarketInfo>(data);

            //Find surrounding systems
            SurroundingInfo[] surroundingSystems = await sphereUrl
                .SetQueryParams(new
                {
                    systemName = originMarket.Name,
                    radius = jumpDistance
                })
                .GetJsonAsync<SurroundingInfo[]>();

            //Find Stations in those Systems and gets their MarketIds if they have a market
            List<long> nearStations = new List<long>();
            Parallel.ForEach(surroundingSystems.Split(speed), q =>
            {
                List<long> temp = q.SelectMany(system => stationsUrl.SetQueryParam("systemName", system.Name).GetJsonAsync<SystemInfo>().Result.Stations
                .Where(station => station.HaveMarket)).Select(sta => sta.MarketId).ToList();
                lock (nearStations)
                    nearStations.AddRange(temp);
            });

            //Gets MarketInfo for every previously found market
            List<MarketInfo> nearMarkets = new List<MarketInfo>();
            Parallel.ForEach(nearStations.Split(speed), q =>
            {
                List<MarketInfo> temp = q.Select(market => marketUrl.SetQueryParam("marketId", market).GetJsonAsync<MarketInfo>().Result).ToList();
                lock (nearMarkets)
                    nearMarkets.AddRange(temp);
            });

            //Filters for goods that are available
            Commodity[] availableGoods = originMarket.Commodities.Where(c => c.Stock > 0).ToArray();

            //Find best selling value for each commodity in origin market
            string bestGood = "Error";
            long bestAmount = 0;
            long bestPrice = 0;
            long bestSellId = 0;
            long investmentPrice = 1;
            foreach (Commodity com in availableGoods)
            {   //Checks every Commodity that is available to buy
                foreach (MarketInfo market in nearMarkets)
                {   //Checks the Prices for this commodity in every market
                    if (market.Commodities.Any(c => c.Id == com.Id))
                    {   //Checks if the market in question knows and buys the commodity
                        Commodity subject = market.Commodities.First(c => c.Id == com.Id);
                        long sellCapacity = Math.Min(Math.Min(cargoCapacity, com.Stock), subject.Demand);
                        if ((subject.SellPrice - com.BuyPrice) * sellCapacity > (bestPrice - investmentPrice) * bestAmount && com.BuyPrice * sellCapacity <= budget)
                        {   //Replaces best data with new best data if you make more profit and the investment is still smaller than the budget
                            bestGood = subject.Name;
                            bestAmount = sellCapacity;
                            bestPrice = subject.SellPrice;
                            bestSellId = market.MarketId;
                            investmentPrice = com.BuyPrice;
                        }
                    }
                }
            }
            //Gets Data finalized
            SalesInfo route = new SalesInfo
            {
                Amount = bestAmount,
                MarketId = bestSellId,
                StationNameBuy = originMarket.SName,
                SysNameBuy = originMarket.Name,
                StationNameSell = nearMarkets.First(m => m.MarketId == bestSellId).SName,
                SysNameSell = nearMarkets.First(m => m.MarketId == bestSellId).Name,
                UnitBuyPrice = investmentPrice,
                UnitSellPrice = bestPrice,
                GoodName = bestGood
            };
            return route;
        }
    }
}