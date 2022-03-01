using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Squadrons
{
    [EventType("SquadronCreated")]
    public class SquadronCreated : EventBase
    {
        public string SquadronName { get; set; }
    }
}