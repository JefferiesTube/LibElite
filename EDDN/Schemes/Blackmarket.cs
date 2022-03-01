using System;
using Newtonsoft.Json;

namespace LibElite.EDDN.Schemes
{
    public class Blackmarket
    {
        [JsonProperty("header")]
        public MessageHeader Header;

        [JsonProperty("message")]
        public BlackMarketMessage Message;
    }

    public class BlackMarketMessage
    {
        [JsonProperty("systemName")]
        public string SystemName;

        [JsonProperty("stationName")]
        public string StationName;

        [JsonProperty("marketId")]
        public long MarketID;

        [JsonProperty("timestamp")]
        public DateTime Timestamp;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("sellPrice")]
        public int SellPrice;

        [JsonProperty("prohibited")]
        public bool Prohibited;
    }
}