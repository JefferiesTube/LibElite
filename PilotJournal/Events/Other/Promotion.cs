using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("Promotion")]
    public class Promotion : EventBase
    {
        public int Combat { get; set; }
        public int Trade { get; set; }
        public int Explore { get; set; }
        public int CQC { get; set; }
        public int Federation { get; set; }
        public int Empire { get; set; }
    }
}