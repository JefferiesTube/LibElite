using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Exploration
{
    [EventType("DiscoveryScan")]
    public class DiscoveryScan : EventBase
    {
        public long SystemAddress { get; set; }
        public int Bodies { get; set; }
    }
}