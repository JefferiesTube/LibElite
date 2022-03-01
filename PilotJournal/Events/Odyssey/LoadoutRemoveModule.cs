using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Odyssey
{
    [EventType("LoadoutRemoveModule")]
    public class LoadoutRemoveModule : EventBase
    {
        public long SuitID { get; set; }
        public string SuitName { get; set; }
        public string SlotName { get; set; }
        public long LoadoutID { get; set; }
        public string LoadoutName { get; set; }
        public string ModuleName { get; set; }
        public long SuitModuleID { get; set; }
    }
}