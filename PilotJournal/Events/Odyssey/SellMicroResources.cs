using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Odyssey
{

    [EventType("SellMicroResources")]
    public class SellMicroResources : EventBase
    {
        public MicroResource[] MicroResources { get; set; }
        public int Price { get; set; }
        public long MarketID { get; set; }
    }

    public class MicroResource
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public int Count { get; set; }
    }
}