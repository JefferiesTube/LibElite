using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Trade
{
    [EventType("AsteroidCracked")]
    public class AsteroidCracked : EventBase
    {
        public string Body { get; set; }
    }
}