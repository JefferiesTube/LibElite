using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("JetConeDamage")]
    public class JetConeDamage : EventBase
    {
        public string Module { get; set; }
    }
}