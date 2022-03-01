using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Combat
{
    [EventType("Interdicted")]
    public class Interdicted : EventBase
    {
        public bool Submitted { get; set; }
        public string Interdictor { get; set; }
        public string Interdictor_Localised { get; set; }
        public bool IsPlayer { get; set; }
        public CombatRank CombatRank { get; set; }
        public string Faction { get; set; }
        public string Power { get; set; }
    }
}