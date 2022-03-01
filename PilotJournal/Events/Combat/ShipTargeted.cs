using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Combat
{
    [EventType("ShipTargeted")]
    public class ShipTargeted : EventBase
    {
        public bool TargetLocked { get; set; }
        public string Ship { get; set; }
        public string Ship_Localised { get; set; }
        public int ScanStage { get; set; }
        public string PilotName { get; set; }
        public string PilotName_Localised { get; set; }
        public string PilotRank { get; set; }
        public double ShieldHealth { get; set; }
        public double HullHealth { get; set; }
        public string Faction { get; set; }
        public string LegalStatus { get; set; }
        public int Bounty { get; set; }
        public string SubSystem { get; set; }
        public string Subsystem_Localised { get; set; }
        public double SubSystemHealth { get; set; }
        public string SquadronID { get; set; }
        public string Power { get; set; }
    }
}