using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("ShipyardBuy")]
    public class ShipyardBuy : EventBase
    {
        public long MarketID { get; set; }
        public string ShipType { get; set; }
        public string ShipType_Localised { get; set; }
        public int ShipPrice { get; set; }
        public string StoreOldShip { get; set; }
        public int StoreShipID { get; set; }
        public string SellOldShip { get; set; }
        public int SellShipID { get; set; }
        public int SellPrice { get; set; }
    }
}