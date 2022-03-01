using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("CrewAssign")]
    public class CrewAssign : EventBase
    {
        public string Name { get; set; }
        public int CrewID { get; set; }
        public string Role { get; set; }
    }
}