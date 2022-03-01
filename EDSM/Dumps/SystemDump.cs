using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace LibElite.EDSM.Dumps
{
    public class SystemDumpEntry
    {
        [J("id")] public long? Id { get; set; }
        [J("id64")] public long? Id64 { get; set; }
        [J("name")] public string Name { get; set; }
        [J("coords")] public Coords Coords { get; set; }
        [J("allegiance")] public string Allegiance { get; set; }
        [J("government")] public string Government { get; set; }
        [J("state")] public object State { get; set; }
        [J("economy")] public object Economy { get; set; }
        [J("security")] public string Security { get; set; }
        [J("population")] public long? Population { get; set; }
        [J("controllingFaction")] public ControllingFaction ControllingFaction { get; set; }
        [J("stations")] public Station[] Stations { get; set; }
        [J("bodies")] public object[] Bodies { get; set; }
        [J("date")] public DateTimeOffset Date { get; set; }
    }

    public class ControllingFaction
    {
        [J("id")] public long? Id { get; set; }
        [J("name")] public string Name { get; set; }
        [J("allegiance")] public string Allegiance { get; set; }
        [J("government")] public string Government { get; set; }
        [J("isPlayer")] public bool IsPlayer { get; set; }
    }

    public class Coords
    {
        [J("x")] public double X { get; set; }
        [J("y")] public double Y { get; set; }
        [J("z")] public double Z { get; set; }
    }

    public class Station
    {
        [J("id")] public long? Id { get; set; }
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
    }

    public class UpdateTime
    {
        [J("information")] public DateTimeOffset Information { get; set; }
        [J("market")] public object Market { get; set; }
        [J("shipyard")] public object Shipyard { get; set; }
        [J("outfitting")] public object Outfitting { get; set; }
    }
}