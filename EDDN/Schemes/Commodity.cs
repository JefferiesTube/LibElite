using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LibElite.EDDN.Schemes
{
    public class Commodity
    {
        [JsonProperty("header")]
        public MessageHeader Header;

        [JsonProperty("message")]
        public CommodityMessage Message;
    }

    public class CommodityMessage
    {
        [JsonProperty("systemName")]
        public string SystemName;
        [JsonProperty("stationName")]
        public string StationName;
        [JsonProperty("marketId")]
        public long MarketID;
        [JsonProperty("horizons")]
        public bool Horizons;
        [JsonProperty("timestamp")]
        public DateTime Timestamp;
        [JsonProperty("commodities")]
        public CommodityEntry[] Commodities;
        [JsonProperty("economies")]
        public DateTime Economies;
        [JsonProperty("prohibited")]
        public string[] Prohibited;
    }

    public class CommodityEntry
    {
        [JsonProperty("name")]
        public string Name;
        [JsonProperty("meanPrice")]
        public int MeanPrice;
        [JsonProperty("buyPrice")]
        public int BuyPrice;
        [JsonProperty("stock")]
        public int Stock;
        [JsonProperty("stockBracket")]
        public int StockBracket;
        [JsonProperty("sellPrice")]
        public int SellPrice;
        [JsonProperty("demand")]
        public int Demand;
        [JsonProperty("demandBracket")]
        public int DemandBracket;
        [JsonProperty("statusFlags")]
        public string[] StatusFlags;
    }

    public class CommodityEconomy
    {
        [JsonProperty("name")]
        public string Name;
        [JsonProperty("proportion")]
        public double Proportion;
    }
}
