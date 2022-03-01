using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("DatalinkScan")]
    public class DatalinkScan : EventBase
    {
        public string Message { get; set; }
        public string Message_Localised { get; set; }
    }
}