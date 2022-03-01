using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("NpcCrewRank")]
    public class NpcCrewRank : EventBase
    {
        public int NpcCrewId { get; set; }
        public string NpcCrewName { get; set; }
        public CombatRank RankCombat { get; set; }
    }
}