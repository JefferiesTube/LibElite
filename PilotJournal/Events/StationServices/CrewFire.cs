using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("CrewFire")]
    public class CrewFire : EventBase
    {
        public string Name { get; set; }
        public int CrewID { get; set; }
    }
}