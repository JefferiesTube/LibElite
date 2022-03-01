using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Odyssey
{
    [EventType("TradeMicroResources")]
    public class TradeMicroResources : EventBase
    {
        public TradeOffers[] Offered { get; set; }
        public string Received { get; set; }
        public string Received_Localised { get; set; }
        public string Category { get; set; }
        public int Count { get; set; }
        public int TotalCount { get; set; }
        public long MarketID { get; set; }
    }

    public class TradeOffers
    {
        public string Name { get; set; }
        public string Name_Localised { get; set; }
        public string Category { get; set; }
        public int Count { get; set; }
    }
}