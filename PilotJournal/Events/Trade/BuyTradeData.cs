using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Trade
{
    [EventType("BuyTradeData")]
    public class BuyTradeData : EventBase
    {
        public string System { get; set; }
        public int Cost { get; set; }
    }
}