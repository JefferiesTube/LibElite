using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("SendText")]
    public class SendText : EventBase
    {
        public string To { get; set; }
        public string To_Localised { get; set; }
        public string Message { get; set; }
        public bool Sent { get; set; }
    }
}