using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("SearchAndRescue")]
    public class SearchAndRescue : EventBase
    {
        public long MarketID { get; set; }
        public string Name { get; set; }
        public string Name_Localised { get; set; }
        public int Count { get; set; }
        public int Reward { get; set; }
    }
}