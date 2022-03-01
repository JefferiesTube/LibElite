using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Travel
{
    [EventType("DockingDenied")]
    public class DockingDenied : EventBase
    {
        public string StationName { get; set; }
        public string StationType { get; set; }
        public long MarketID { get; set; }
        public DockingDenialReason Reason { get; set; }
    }
}