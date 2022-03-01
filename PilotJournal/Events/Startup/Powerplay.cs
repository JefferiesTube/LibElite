using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Startup
{
    [EventType("Powerplay")]
    public class Powerplay : EventBase
    {
        public string Power { get; set; }
        public int Rank { get; set; }
        public int Merits { get; set; }
        public int Votes { get; set; }
        public long TimePledged { get; set; }
    }
}