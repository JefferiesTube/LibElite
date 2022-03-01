using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("Outfitting")]
    public class Outfitting : EventBase
    {
        public long MarketID { get; set; }
        public string StationName { get; set; }
        public string StarSystem { get; set; }
    }
}