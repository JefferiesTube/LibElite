using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("MaterialTrade")]
    public class MaterialTrade : EventBase
    {
        public long MarketID { get; set; }
        public string TraderType { get; set; }
        public MaterialTradeEntry Paid { get; set; }
        public MaterialTradeEntry Received { get; set; }
    }

    public class MaterialTradeEntry
    {
        public string Material { get; set; }
        public string Material_Localised { get; set; }
        public string Category { get; set; }
        public string Category_Localised { get; set; }
        public int Quantity { get; set; }
    }
}