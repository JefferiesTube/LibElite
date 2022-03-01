using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Squadrons
{
    [EventType("KickedFromSquadron")]
    public class KickedFromSquadron : EventBase
    {
        public string SquadronName { get; set; }
    }
}