using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("FuelScoop")]
    public class FuelScoop : EventBase
    {
        public float Scooped { get; set; }
        public float Total { get; set; }
    }
}