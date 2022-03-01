using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Squadrons
{
    [EventType("SquadronDemotion")]
    public class SquadronDemotion : EventBase
    {
        public string SquadronName { get; set; }
        public int OldRank { get; set; }
        public int NewRank { get; set; }
    }
}