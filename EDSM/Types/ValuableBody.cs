using Newtonsoft.Json;

namespace LibElite.EDSM.Types
{
    public class ValuableBody
    {
        [JsonProperty("bodyId")]
        public long BodyId { get; set; }

        [JsonProperty("bodyName")]
        public string BodyName { get; set; }

        [JsonProperty("distance")]
        public long Distance { get; set; }

        [JsonProperty("valueMax")]
        public long ValueMax { get; set; }
    }
}