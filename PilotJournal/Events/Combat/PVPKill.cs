using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Combat
{
    [EventType("PVPKill")]
    public class PVPKill : EventBase
    {
        public string Victim { get; set; }
        public CombatRank CombatRank { get; set; }
    }
}