using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Travel
{
    [EventType("SupercruiseEntry")]
    public class SupercruiseEntry : EventBase
    {
        public string Starsystem { get; set; }
        public string SystemAddress { get; set; }
        public bool Taxi { get; set; }
        public bool Multicrew { get; set; }
    }
}