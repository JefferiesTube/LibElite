using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("TechnologyBroker")]
    public class TechnologyBroker : EventBase
    {
        public string BrokerType { get; set; }
        public long MarketID { get; set; }
        public TechnologyBrokerUnlockEntry[] ItemsUnlocked { get; set; }
        public TechnologyBrokerCommodityEntry[] Commodities { get; set; }
        public TechnologyBrokerMaterialEntry[] Materials { get; set; }
    }

    public class TechnologyBrokerUnlockEntry
    {
        public string Name { get; set; }
        public string Name_Localised { get; set; }
    }

    public class TechnologyBrokerCommodityEntry
    {
        public string Name { get; set; }
        public string Name_Localised { get; set; }
        public int Count { get; set; }
    }

    public class TechnologyBrokerMaterialEntry
    {
        public string Name { get; set; }
        public string Name_Localised { get; set; }
        public int Count { get; set; }
        public MaterialCategory Category { get; set; }
    }
}