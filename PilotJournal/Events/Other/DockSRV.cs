using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("DockSRV")]
    public class DockSRV : EventBase
    {
        public int ID { get; set; }
    }
}