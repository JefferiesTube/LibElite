using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("JoinACrew")]
    public class JoinACrew : EventBase
    {
        public string Captain { get; set; }
    }
}