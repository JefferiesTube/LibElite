using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Odyssey
{
    [EventType("SuitLoadout")]
    public class SuitLoadout : EventBase
    {
        public long SuitID { get; set; }
        public string SuitName { get; set; }
        public string SuitName_Localised { get; set; }
        public long LoadoutID { get; set; }
        public string LoadoutName { get; set; }
        public SuitModule[] Modules { get; set; }
        public SuitModule[] SuitMods { get; set; }
        public string[] WeaponMods { get; set; }
    }
}