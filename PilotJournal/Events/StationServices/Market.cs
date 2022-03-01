using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("Market")]
    public class Market : EventBase
    {
        public long MarketID { get; set; }
        public string StationName { get; set; }
        public string StarSystem { get; set; }
        public StationType StationType { get; set; }
        public DockingAccess CarrierDockingAccess { get; set; }
        public MarketEntry[] Items { get; set; }
    }

    public class MarketEntry
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int BuyPrice { get; set; }
        public int SellPrice { get; set; }
        public int MeanPrice { get; set; }
        public int StockBracket { get; set; }
        public int DemandBracket { get; set; }
        public int Stock { get; set; }
        public int Demand { get; set; }
        public bool Consumer { get; set; }
        public bool Producer { get; set; }
        public bool Rare { get; set; }
    }
}