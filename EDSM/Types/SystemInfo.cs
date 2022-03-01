using System;
using Newtonsoft.Json;

namespace LibElite.EDSM.Types
{
    public class SystemInfo
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("id64")]
        public long Id64 { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("stations")]
        public Station[] Stations { get; set; }

        [JsonProperty("estimatedValue")]
        public long EstimatedValue { get; set; }

        [JsonProperty("estimatedValueMapped")]
        public long EstimatedValueMapped { get; set; }

        [JsonProperty("valuableBodies")]
        public ValuableBody[] ValuableBodies { get; set; }

        public bool IsValid()
        {
            return Id > 0;
        }
    }

    public class UpdateTime
    {
        [JsonProperty("information")]
        public DateTimeOffset? Information { get; set; }

        [JsonProperty("market")]
        public DateTimeOffset? Market { get; set; }

        [JsonProperty("shipyard")]
        public DateTimeOffset? Shipyard { get; set; }

        [JsonProperty("outfitting")]
        public DateTimeOffset? Outfitting { get; set; }
    }
}