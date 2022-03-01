using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("Resurrect")]
    public class Resurrect : EventBase
    {
        public string Option { get; set; }
        public int Cost { get; set; }
        public bool Bankrupt { get; set; }
    }
}