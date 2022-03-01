using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("AfmuRepairs")]
    public class AfmuRepairs : EventBase
    {
        public string Module { get; set; }
        public bool FullyRepaired { get; set; }
        public float Health { get; set; }
    }
}