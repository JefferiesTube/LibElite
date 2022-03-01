using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("ShipyardSell")]
    public class ShipyardSell : EventBase
    {
        public long MarketID { get; set; }
        public long ShipMarketID { get; set; }
        public string ShipType { get; set; }
        public string ShipType_Localised { get; set; }
        public int SellShipID { get; set; }
        public int ShipPrice { get; set; }
        public string System { get; set; }
    }
}