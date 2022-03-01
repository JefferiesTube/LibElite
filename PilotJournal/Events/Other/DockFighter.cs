using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("DockFighter")]
    public class DockFighter : EventBase
    {
        public int ID { get; set; }
    }
}