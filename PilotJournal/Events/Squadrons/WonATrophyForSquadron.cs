using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Squadrons
{
    [EventType("WonATrophyForSquadron")]
    public class WonATrophyForSquadron : EventBase
    {
        public string SquadronName { get; set; }
    }
}