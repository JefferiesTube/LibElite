using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Squadrons
{
    [EventType("AppliedToSquadron")]
    public class AppliedToSquadron : EventBase
    {
        public string SquadronName { get; set; }
    }
}