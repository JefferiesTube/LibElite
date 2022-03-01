using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("CommunityGoalReward")]
    public class CommunityGoalReward : EventBase
    {
        public int CGID { get; set; }
        public string Name { get; set; }
        public string System { get; set; }
        public string Reward { get; set; }
    }
}