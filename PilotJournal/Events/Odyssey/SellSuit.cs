using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Odyssey
{
    [EventType("SellSuit")]
    public class SellSuit : EventBase
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public long SuitID { get; set; }
    }
}