using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("CommunityGoalDiscard")]
    public class CommunityGoalDiscard : EventBase
    {
        public int CGID { get; set; }
        public string Name { get; set; }
        public string System { get; set; }
    }
}