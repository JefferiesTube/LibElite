using LibElite.PilotJournal.Events.Travel;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace LibElite.PilotJournal.Events.BaseClasses
{
    public abstract class JumpEvent : EventBase
    {
        [J("Docked")] public bool Docked { get; set; }
        [J("StationName")] public string StationName { get; set; }
        [J("StationType")] public string StationType { get; set; }
        [J("MarketID")] public long MarketId { get; set; }
        [J("StationFaction")] public SystemFaction StationFaction { get; set; }
        [J("StationGovernment")] public string StationGovernment { get; set; }
        [J("StationGovernment_Localised")] public string StationGovernmentLocalised { get; set; }
        [J("StationServices")] public string[] StationServices { get; set; }
        [J("StationEconomy")] public string StationEconomy { get; set; }
        [J("StationEconomy_Localised")] public string StationEconomyLocalised { get; set; }
        [J("StationEconomies")] public StationEconomy[] StationEconomies { get; set; }
        [J("StarSystem")] public string StarSystem { get; set; }
        [J("SystemAddress")] public long SystemAddress { get; set; }
        [J("StarPos")] public double[] StarPos { get; set; }
        [J("SystemAllegiance")] public string SystemAllegiance { get; set; }
        [J("SystemEconomy")] public string SystemEconomy { get; set; }
        [J("SystemEconomy_Localised")] public string SystemEconomyLocalised { get; set; }
        [J("SystemSecondEconomy")] public string SystemSecondEconomy { get; set; }
        [J("SystemSecondEconomy_Localised")] public string SystemSecondEconomyLocalised { get; set; }
        [J("SystemGovernment")] public string SystemGovernment { get; set; }
        [J("SystemGovernment_Localised")] public string SystemGovernmentLocalised { get; set; }
        [J("SystemSecurity")] public string SystemSecurity { get; set; }
        [J("SystemSecurity_Localised")] public string SystemSecurityLocalised { get; set; }
        [J("Population")] public long Population { get; set; }
        [J("Body")] public string Body { get; set; }
        [J("BodyID")] public long BodyId { get; set; }
        [J("BodyType")] public string BodyType { get; set; }
    }
}