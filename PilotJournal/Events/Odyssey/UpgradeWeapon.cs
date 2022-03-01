using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Odyssey
{
    [EventType("UpgradeWeapon")]
    public class UpgradeWeapon : EventBase
    {
        public string Name { get; set; }
        public long SuitModuleID { get; set; }
        public string Class { get; set; }
        public int Cost { get; set; }
    }
}