using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("CrewMemberJoins")]
    public class CrewMemberJoins : EventBase
    {
        public string Crew { get; set; }
    }
}