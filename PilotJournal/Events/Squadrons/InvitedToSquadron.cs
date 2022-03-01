using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Squadrons
{
    [EventType("InvitedToSquadron")]
    public class InvitedToSquadron : EventBase
    {
        public string SquadronName { get; set; }
    }
}