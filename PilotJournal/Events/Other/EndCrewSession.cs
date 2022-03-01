using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("EndCrewSession")]
    public class EndCrewSession : EventBase
    {
        public bool OnCrime { get; set; }
    }
}