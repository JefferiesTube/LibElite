using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("CrewHire")]
    public class CrewHire : EventBase
    {
        public string Name { get; set; }
        public int CrewID { get; set; }
        public string Faction { get; set; }
        public int Cost { get; set; }
        public CombatRank CombatRank { get; set; }
    }
}