using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Travel
{
    [EventType("DockingCancelled")]
    public class DockingCancelled : EventBase
    {
        public string StationName { get; set; }
        public string StationType { get; set; }
        public long MarketID { get; set; }
    }
}