using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Squadrons
{
    [EventType("LeftSquadron")]
    public class LeftSquadron : EventBase
    {
        public string SquadronName { get; set; }
    }
}