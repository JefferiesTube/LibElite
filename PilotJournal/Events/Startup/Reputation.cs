using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Startup
{
    [EventType("Reputation")]
    public class Reputation : EventBase
    {
        public double Empire { get; set; }
        public double Federation { get; set; }
        public double Independent { get; set; }
        public double Alliance { get; set; }
    }
}