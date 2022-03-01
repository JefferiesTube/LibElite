using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Squadrons
{
    [EventType("DisbandedSquadron")]
    public class DisbandedSquadron : EventBase
    {
        public string SquadronName { get; set; }
    }
}