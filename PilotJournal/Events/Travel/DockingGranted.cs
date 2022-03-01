using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Travel
{
    [EventType("DockingGranted")]
    public class DockingGranted : EventBase
    {
        public string StationName { get; set; }
        public string StationType { get; set; }
        public long MarketID { get; set; }
        public int LandingPad { get; set; }
    }
}