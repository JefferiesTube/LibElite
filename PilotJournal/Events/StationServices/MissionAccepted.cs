using System;
using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("MissionAccepted")]
    public class MissionAccepted : EventBase
    {
        public string Name { get; set; }
        public string LocalisedName { get; set; }
        public string Faction { get; set; }
        public int MissionID { get; set; }
        public string Influence { get; set; }
        public string Reputation { get; set; }
        public int Reward { get; set; }
        public bool Wing { get; set; }
        public string Commodity { get; set; }
        public string Commodity_Localised { get; set; }
        public int Count { get; set; }
        public string Donation { get; set; }
        public int Donated { get; set; }
        public string Target { get; set; }
        public string Target_Localised { get; set; }
        public string TargetType { get; set; }
        public string TargetType_Localised { get; set; }
        public string TargetFaction { get; set; }
        public int KillCount { get; set; }
        public DateTime Expiry { get; set; }
        public string DestinationSystem { get; set; }
        public string DestinationStation { get; set; }
        public string NewDestinationSystem { get; set; }
        public string NewDestinationStation { get; set; }
        public int PassengerCount { get; set; }
        public bool PassengerVIPs { get; set; }
        public bool PassengerWanted { get; set; }
        public string PassengerType { get; set; }
    }
}