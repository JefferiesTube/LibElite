using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("LaunchDrone")]
    public class LaunchDrone : EventBase
    {
        public DroneType Type { get; set; }
    }
}