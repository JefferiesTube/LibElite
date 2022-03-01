using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("ReceiveText")]
    public class ReceiveText : EventBase
    {
        public string From { get; set; }
        public string From_Localised { get; set; }
        public string To { get; set; }
        public string Message { get; set; }
        public string Message_Localised { get; set; }
        public MessageChannel Channel { get; set; }
    }
}