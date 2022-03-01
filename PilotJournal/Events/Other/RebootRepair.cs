using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("RebootRepair")]
    public class RebootRepair : EventBase
    {
        public string[] Modules { get; set; }
    }
}