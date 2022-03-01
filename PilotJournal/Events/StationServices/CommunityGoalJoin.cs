using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("CommunityGoalJoin")]
    public class CommunityGoalJoin : EventBase
    {
        public int CGID { get; set; }
        public string Name { get; set; }
        public string System { get; set; }
    }
}