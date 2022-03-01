using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("CrewMemberQuits")]
    public class CrewMemberQuits : EventBase
    {
        public string Crew { get; set; }
    }
}