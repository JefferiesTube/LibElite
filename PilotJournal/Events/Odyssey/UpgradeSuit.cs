using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Odyssey
{
    [EventType("UpgradeSuit")]
    public class UpgradeSuit : EventBase
    {
        public string Name { get; set; }
        public long SuitID { get; set; }
        public string Class { get; set; }
        public int Cost { get; set; }
    }
}