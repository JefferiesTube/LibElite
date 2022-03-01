using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Squadrons
{
    [EventType("SquadronPromotion")]
    public class SquadronPromotion : EventBase
    {
        public string SquadronName { get; set; }
        public int OldRank { get; set; }
        public int NewRank { get; set; }
    }
}