using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Squadrons
{
    [EventType("JoinedSquadron")]
    public class JoinedSquadron : EventBase
    {
        public string SquadronName { get; set; }
    }
}