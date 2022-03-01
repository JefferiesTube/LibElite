using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Exploration
{
    [EventType("FSSAllBodiesFound")]
    public class FSSAllBodiesFound : EventBase
    {
        public string SystemName { get; set; }
        public long SystemAddress { get; set; }
        public int Count { get; set; }
    }
}