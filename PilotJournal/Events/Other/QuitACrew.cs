using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("QuitACrew")]
    public class QuitACrew : EventBase
    {
        public string Captain { get; set; }
    }
}