using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("WingJoin")]
    public class WingJoin : EventBase
    {
        public string[] Others { get; set; }
    }
}