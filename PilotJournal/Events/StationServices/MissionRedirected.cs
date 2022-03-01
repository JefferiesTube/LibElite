using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("MissionRedirected")]
    public class MissionRedirected : EventBase
    {
        public string Name { get; set; }
        public int MissionID { get; set; }
        public string NewDestinationStation { get; set; }
        public string OldDestinationStation { get; set; }
        public string NewDestinationSystem { get; set; }
        public string OldDestinationSystem { get; set; }
    }
}