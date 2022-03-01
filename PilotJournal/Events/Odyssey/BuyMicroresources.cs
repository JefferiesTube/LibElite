using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Odyssey
{
    [EventType("BuyMicroResources")]
    public class BuyMicroResources : EventBase
    {
        public string Name { get; set; }
        public string Name_Localised { get; set; }
        public string Category { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
        public long MarketID { get; set; }
    }
}