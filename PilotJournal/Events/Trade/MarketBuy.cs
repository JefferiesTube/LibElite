using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Trade
{
    [EventType("MarketBuy")]
    public class MarketBuy : EventBase
    {
        public long MarketID { get; set; }
        public string Type { get; set; }
        public string Type_Localised { get; set; }
        public int Count { get; set; }
        public int BuyPrice { get; set; }
        public long TotalCost { get; set; }
    }
}