using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Travel
{
    [EventType("Undocked")]
    public class Undocked : EventBase
    {
        public string StationName { get; set; }
        public string StationType { get; set; }
        public bool Taxi { get; set; }
        public bool Multicrew { get; set; }
        public long MarketID { get; set; }
    }
}