using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("USSDrop")]
    public class USSDrop : EventBase
    {
        public string USSType { get; set; }
        public string USSType_Localised { get; set; }
        public int USSThreat { get; set; }
    }
}