using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("ScientificResearch")]
    public class ScientificResearch : EventBase
    {
        public long MarketID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Count { get; set; }
    }
}