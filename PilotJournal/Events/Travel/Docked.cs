using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Travel
{
    public class EconomyEntry
    {
        public string Name { get; set; }
        public string Name_Localised { get; set; }
        public double Proportion { get; set; }
    }

    [EventType("Docked")]
    public class Docked : EventBase
    {
        public string StationName { get; set; }
        public long MarketID { get; set; }
        public long SystemAddress { get; set; }
        public string StarSystem { get; set; }
        public string StationType { get; set; }
        public string StationState { get; set; }
        public bool CockpitBreach { get; set; }
        public object StationFaction { get; set; }
        public string FactionState { get; set; }
        public string StationAllegiance { get; set; }
        public string StationEconomy { get; set; }
        public string StationEconomy_Localised { get; set; }
        public double DistFromStarLS { get; set; }
        public string StationGovernment { get; set; }
        public string StationGovernment_Localised { get; set; }
        public StationService[] StationServices { get; set; }
        public EconomyEntry[] StationEconomies { get; set; }
        public bool Wanted { get; set; }
        public bool Taxi { get; set; }
        public bool ActiveFine { get; set; }
        public bool Multicrew { get; set; }
    }
}