using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LibElite.EDDN.Schemes
{
    public class Shipyard
    {
        [JsonProperty("header")]
        public MessageHeader Header;

        [JsonProperty("message")]
        public ShipyardMessage Message;
    }

    public class ShipyardMessage
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
        [JsonProperty("ships")]
        public string[] Ships;
    }
}
