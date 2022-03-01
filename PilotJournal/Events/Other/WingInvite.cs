using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("WingInvite")]
    public class WingInvite : EventBase
    {
        public string Name { get; set; }
    }
}