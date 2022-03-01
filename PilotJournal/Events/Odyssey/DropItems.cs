using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Odyssey
{
    [EventType("DropItems")]
    public class DropItems : EventBase
    {
        public string Name { get; set; }
        public string Name_Localised { get; set; }
        public string Type { get; set; }
        public long OwnerID { get; set; }
        public long MissionID { get; set; }
        public int Count { get; set; }
    }
}