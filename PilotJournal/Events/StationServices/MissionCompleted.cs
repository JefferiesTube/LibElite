using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("MissionCompleted")]
    public class MissionCompleted : EventBase
    {
        public string Name { get; set; }
        public string Faction { get; set; }
        public int MissionID { get; set; }
        public string Commodity { get; set; }
        public string Commodity_Localised { get; set; }
        public int Count { get; set; }
        public string Target { get; set; }
        public string Target_Localised { get; set; }
        public string TargetType { get; set; }
        public string TargetType_Localised { get; set; }
        public string TargetFaction { get; set; }
        public int Reward { get; set; }
        public string Donation { get; set; }
        public int Donated { get; set; }
        public int KillCount { get; set; }
        public string[] PermitsAwarded { get; set; }
        public string DestinationSystem { get; set; }
        public string DestinationStation { get; set; }
        public string NewDestinationSystem { get; set; }
        public CommodityReward[] CommodityReward { get; set; }
        public MaterialReward[] MaterialsReward { get; set; }
        public FactionEffect[] FactionEffects { get; set; }
        public string NewDestinationStation { get; set; }
    }

    public class CommodityReward
    {
        public string Name { get; set; }
        public string Name_Localised { get; set; }
        public int Count { get; set; }
    }

    public class MaterialReward
    {
        public string Name { get; set; }
        public string Name_Localised { get; set; }
        public int Count { get; set; }
        public string Category { get; set; }
        public string Category_Localised { get; set; }
    }

    public class FactionEffect
    {
        public string Faction { get; set; }
        public FactionEffectTrend[] Effects { get; set; }
        public FactionInfluenceTrend[] Influence { get; set; }
        public string Reputation { get; set; }
        public string ReputationTrend { get; set; }
    }

    public class FactionEffectTrend
    {
        public string Effect { get; set; }
        public string Effect_Localised { get; set; }
        public string Trend { get; set; }
    }

    public class FactionInfluenceTrend
    {
        public string System { get; set; }
        public long SystemAddress { get; set; }
        public string Trend { get; set; }
        public string Influence { get; set; }
    }
}