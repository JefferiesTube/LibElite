using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace LibElite.EDSM.Dumps
{
    public partial class StationDump
    {
        [J("id")] public long Id { get; set; }
        [J("marketId")] public long? MarketId { get; set; }
        [J("type")] public string Type { get; set; }
        [J("name")] public string Name { get; set; }
        [J("distanceToArrival")] public long? DistanceToArrival { get; set; }
        [J("allegiance")] public string Allegiance { get; set; }
        [J("government")] public string Government { get; set; }
        [J("economy")] public string Economy { get; set; }
        [J("secondEconomy")] public object SecondEconomy { get; set; }
        [J("haveMarket")] public bool HaveMarket { get; set; }
        [J("haveShipyard")] public bool HaveShipyard { get; set; }
        [J("haveOutfitting")] public bool HaveOutfitting { get; set; }
        [J("otherServices")] public object[] OtherServices { get; set; }
        [J("updateTime")] public UpdateTime UpdateTime { get; set; }
        [J("systemId")] public long SystemId { get; set; }
        [J("systemId64")] public long SystemId64 { get; set; }
        [J("systemName")] public string SystemName { get; set; }
    }
}