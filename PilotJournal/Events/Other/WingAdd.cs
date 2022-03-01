using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("WingAdd")]
    public class WingAdd : EventBase
    {
        public string Name { get; set; }
    }
}