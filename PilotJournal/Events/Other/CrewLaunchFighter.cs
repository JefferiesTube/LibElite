using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("CrewLaunchFighter")]
    public class CrewLaunchFighter : EventBase
    {
        public string Crew { get; set; }
        public int ID { get; set; }
    }
}