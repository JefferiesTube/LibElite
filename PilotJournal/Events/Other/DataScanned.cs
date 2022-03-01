using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("DataScanned")]
    public class DataScanned : EventBase
    {
        public string Type { get; set; }
        public string Type_Localised { get; set; }
    }
}