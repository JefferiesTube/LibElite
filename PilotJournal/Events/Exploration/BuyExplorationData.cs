
using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Exploration
{
    [EventType("BuyExplorationData")]
    public class BuyExplorationData : EventBase
    {
        public string System { get; set; }
        public long Cost { get; set; }
    }
}