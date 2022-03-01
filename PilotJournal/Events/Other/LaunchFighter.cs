using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("LaunchFighter")]
    public class LaunchFighter : EventBase
    {
        public string Loadout { get; set; }
        public bool PlayerControlled { get; set; }
        public int ID { get; set; }
    }
}