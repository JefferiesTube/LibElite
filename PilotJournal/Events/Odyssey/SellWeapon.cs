using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Odyssey
{
    [EventType("SellWeapon")]
    public class SellWeapon : EventBase
    {
        public string Name { get; set; }
        public string Name_Localised { get; set; }
        public int Price { get; set; }
        public long SuitModuleID { get; set; }
    }
}