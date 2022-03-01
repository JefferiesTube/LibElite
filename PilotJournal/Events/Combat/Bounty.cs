using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Combat
{
    /// <summary>
    /// When written: player is awarded a bounty for a kill 
    /// </summary>
    [EventType("Bounty")]
    public class Bounty : EventBase
    {
        public BountyReward[] Rewards { get; set; }
        public string Target { get; set; }
        public string Target_Localised { get; set; }
        public string VictimFaction { get; set; }
        public string VictimFaction_Localised { get; set; }
        public long TotalReward { get; set; }
        public int SharedWithOthers { get; set; }

        // For Skimmer only
        public string Faction { get; set; }
        public string Faction_Localised { get; set; }
        public int Reward { get; set; }
    }

    public class BountyReward
    {
        public string Faction { get; set; }
        public int Reward { get; set; }
    }
}