using System;
using Newtonsoft.Json;

namespace LibElite.EDDN.Schemes
{
    public class MessageHeader
    {
        [JsonProperty("uploaderID")]
        public string UploaderID;

        [JsonProperty("softwareName")]
        public string SoftwareName;

        [JsonProperty("softwareVersion")]
        public string SoftwareVersion;

        [JsonProperty("gatewayTimestamp")]
        public DateTime GatewayTimestamp;
    }
}