using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Squadrons
{
    [EventType("SharedBookmarkToSquadron")]
    public class SharedBookmarkToSquadron : EventBase
    {
        public string SquadronName { get; set; }
    }
}