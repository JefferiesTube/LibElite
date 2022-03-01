using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("LaunchSRV")]
    public class LaunchSRV : EventBase
    {
        public bool PlayerControlled { get; set; }
        public string Loadout { get; set; }
        public int ID { get; set; }
    }
}