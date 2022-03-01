using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Odyssey
{
    [EventType("CollectItems")]
    public class CollectItems : EventBase
    {
        public string Name { get; set; }
        public string Name_Localised { get; set; }
        public long OwnerID { get; set; }
        public int Count { get; set; }
        public bool Stolen { get; set; }
        public string Type { get; set; }
    }
}