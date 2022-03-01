using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Travel
{
    [EventType("FSDTarget")]
    public class FSDTarget : EventBase
    {
        public string Starsystem { get; set; }
        public string Name { get; set; }
        public long SystemAddress { get; set; }
        public string StarClass { get; set; }
        public int RemainingJumpsInRoute { get; set; }
    }
}