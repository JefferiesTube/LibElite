using Newtonsoft.Json;

namespace LibElite.EDSM.Types
{
    public class SurroundingInfo
    {
        [JsonProperty("distance")]
        public double Distance { get; set; }

        [JsonProperty("bodyCount")]
        public long? BodyCount { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}