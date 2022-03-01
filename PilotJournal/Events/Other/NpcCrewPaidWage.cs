using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("NpcCrewPaidWage")]
    public class NpcCrewPaidWage : EventBase
    {
        public int NpcCrewId { get; set; }
        public string NpcCrewName { get; set; }
        public int Amount { get; set; }
    }
}