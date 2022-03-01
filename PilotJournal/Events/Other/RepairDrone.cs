using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("RepairDrone")]
    public class RepairDrone : EventBase
    {
        public float HullRepaired { get; set; }
        public float CockpitRepaired { get; set; }
        public float CorrosionRepaired { get; set; }
    }
}