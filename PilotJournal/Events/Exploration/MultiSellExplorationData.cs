using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Exploration
{
    [EventType("MultiSellExplorationData")]
    public class MultiSellExplorationData : EventBase
    {
        public ExplorationRecord[] Discovered { get; set; }
        public long BaseValue { get; set; }
        public int Bonus { get; set; }
        public long TotalEarnings { get; set; }
    }

    public class ExplorationRecord
    {
        public string SystemName { get; set; }
        public int NumBodies { get; set; }
    }
}