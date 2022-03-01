using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("KickCrewMember")]
    public class KickCrewMember : EventBase
    {
        public string Crew { get; set; }
        public bool OnCrime { get; set; }
    }
}