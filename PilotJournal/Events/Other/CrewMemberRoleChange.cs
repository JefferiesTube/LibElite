using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("CrewMemberRoleChange")]
    public class CrewMemberRoleChange : EventBase
    {
        public string Crew { get; set; }
        public CrewRole Role { get; set; }
    }
}