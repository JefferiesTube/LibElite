using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Odyssey
{
    [EventType("CreateSuitLoadout")]
    public class CreateSuitLoadout : EventBase
    {
        public long SuitID { get; set; }
        public string SuitName { get; set; }
        public string SuitName_Localised { get; set; }
        public long LoadoutID { get; set; }
        public string LoadoutName { get; set; }
        public LoadoutModule[] Modules { get; set; }
    }

    public class LoadoutModule
    {
        public string SlotName { get; set; }
        public string ModuleName { get; set; }
        public string ModuleName_Localised { get; set; }
        public long SuitModuleID { get; set; }
    }
}