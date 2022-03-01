using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("BuyDrones")]
    public class BuyDrones : EventBase
    {
        public string Type { get; set; }
        public int Cost { get; set; }
        public int Count { get; set; }
        public int BuyPrice { get; set; }
        public int TotalCost { get; set; }
    }
}