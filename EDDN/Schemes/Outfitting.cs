using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LibElite.EDDN.Schemes
{
    public class Outfitting
    {
        [JsonProperty("header")]
        public MessageHeader Header;

        [JsonProperty("message")]
        public OutfittingMessage Message;
    }

    public class OutfittingMessage
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
        [JsonProperty("modules")]
        public string[] Modules;
    }
}
