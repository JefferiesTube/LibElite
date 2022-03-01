using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Squadrons
{
    [EventType("SquadronStartup")]
    public class SquadronStartup : EventBase
    {
        public string SquadronName { get; set; }
        public int CurrentRank { get; set; }
    }
}