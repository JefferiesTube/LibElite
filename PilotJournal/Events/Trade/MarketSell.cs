using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Trade
{
    [EventType("MarketSell")]
    public class MarketSell : EventBase
    {
        public long MarketID { get; set; }
        public string Type { get; set; }
        public string Type_Localised { get; set; }
        public int Count { get; set; }
        public int SellPrice { get; set; }
        public long TotalSale { get; set; }
        public long AvgPricePaid { get; set; }
        public bool IllegalGoods { get; set; }
        public bool StolenGoods { get; set; }
        public bool BlackMarket { get; set; }
    }
}