using Newtonsoft.Json;

namespace LibElite.EDSM.Types
{
    public class Station
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("marketId")]
        public long MarketId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("distanceToArrival")]
        public double DistanceToArrival { get; set; }

        [JsonProperty("allegiance")]
        public string Allegiance { get; set; }

        [JsonProperty("government")]
        public string Government { get; set; }

        [JsonProperty("economy")]
        public string Economy { get; set; }

        [JsonProperty("secondEconomy")]
        public object SecondEconomy { get; set; }

        [JsonProperty("haveMarket")]
        public bool HaveMarket { get; set; }

        [JsonProperty("haveShipyard")]
        public bool HaveShipyard { get; set; }

        [JsonProperty("haveOutfitting")]
        public bool HaveOutfitting { get; set; }

        [JsonProperty("otherServices")]
        public string[] OtherServices { get; set; }

        [JsonProperty("controllingFaction")]
        public Body ControllingFaction { get; set; }

        [JsonProperty("updateTime")]
        public UpdateTime UpdateTime { get; set; }

        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public Body Body { get; set; }
    }
}