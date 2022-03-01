using System;
using Newtonsoft.Json;

namespace LibElite.EDSM.Types
{
    public class MarketInfo
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("id64")]
        public long Id64 { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("marketId")]
        public long MarketId { get; set; }

        [JsonProperty("sId")]
        public long SId { get; set; }

        [JsonProperty("sName")]
        public string SName { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("commodities")]
        public Commodity[] Commodities { get; set; }
    }

    public class Commodity
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("buyPrice")]
        public long BuyPrice { get; set; }

        [JsonProperty("stock")]
        public long Stock { get; set; }

        [JsonProperty("sellPrice")]
        public long SellPrice { get; set; }

        [JsonProperty("demand")]
        public long Demand { get; set; }

        [JsonProperty("stockBracket")]
        public long StockBracket { get; set; }
    }
}