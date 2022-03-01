using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("MissionFailed")]
    public class MissionFailed : EventBase
    {
        public string Name { get; set; }
        public int MissionID { get; set; }
        public bool Fine { get; set; }
    }  
}