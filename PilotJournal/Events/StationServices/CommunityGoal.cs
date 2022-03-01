using System;
using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("CommunityGoal")]
    public class CommunityGoal : EventBase
    {
        public CommunityGoalEntry[] CurrentGoals { get; set; }
    }

    public class CommunityGoalEntry
    {
        public int CGID { get; set; }
        public string Title { get; set; }
        public string SystemName { get; set; }
        public string MarketName { get; set; }
        public DateTime Expiry { get; set; }
        public bool IsComplete{ get; set; }
        public long  CurrentTotal { get; set; }
        public long PlayerContribution { get; set; }
        public int NumContributors { get; set; }
        public int TopRankSize { get; set; }
        public bool PlayerInTopRank { get; set; }
        public int PlayerPercentileBand { get; set; }
        public string Bonus { get; set; }
        public string TierReached { get; set; }
        public CommunityGoalEntryTopTier TopTier { get; set; }
    }

    public class CommunityGoalEntryTopTier
    {
        public string Name { get; set; }
        public string Bonus { get; set; }
    }
}