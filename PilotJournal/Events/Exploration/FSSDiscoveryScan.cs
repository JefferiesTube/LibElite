using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Exploration
{
    [EventType("FSSDiscoveryScan")]
    public class FSSDiscoveryScan : EventBase
    {
        public double Progress { get; set; }
        public int BodyCount { get; set; }
        public int NonBodyCount { get; set; }
        public string SystemName { get; set; }
        public long SystemAddress { get; set; }
    }
}