using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Startup
{
    public class MissionEntry
    {
        public int MissionID { get; set; }
        public string Name { get; set; }
        public bool PassengerMission { get; set; }
        public long Expires { get; set; }
    }

    [EventType("Missions")]
    public class Missions : EventBase
    {
        public MissionEntry[] Active { get; set; }
        public MissionEntry[] Failed { get; set; }
        public MissionEntry[] Complete { get; set; }
    }
}