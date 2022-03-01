using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("Continued")]
    public class Continued : EventBase
    {
        public int Part { get; set; }
    }
}