using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Travel
{
    [EventType("DockingTimeout")]
    public class DockingTimeout : EventBase
    {
        public string StationName { get; set; }
        public string StationType { get; set; }
        public long MarketID { get; set; }
    }
}