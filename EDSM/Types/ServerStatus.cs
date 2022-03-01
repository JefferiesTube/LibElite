using Newtonsoft.Json;
using System;

namespace LibElite.EDSM.Types
{
    public enum ServerStatus { Danger = 0, Warning = 1, Success = 2 }

    public class EDSMEliteServerStatus
    {
        [JsonProperty("lastUpdate")]
        public DateTimeOffset LastUpdate { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }
    }
}