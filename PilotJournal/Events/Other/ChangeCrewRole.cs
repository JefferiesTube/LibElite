using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("ChangeCrewRole")]
    public class ChangeCrewRole : EventBase
    {
        public CrewRole Role { get; set; }
    }
}