using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Exploration
{
    [EventType("SellExplorationData")]
    public class SellExplorationData : EventBase
    {
        public string[] Systems { get; set; }
        public string[] Discovered { get; set; }
        public int BaseValue { get; set; }
        public int Bonus { get; set; }
        public long TotalEarnings { get; set; }
    }
}