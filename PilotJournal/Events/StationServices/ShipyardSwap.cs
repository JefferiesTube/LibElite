using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("ShipyardSwap")]
    public class ShipyardSwap : EventBase
    {
        public long MarketID { get; set; }
        public string ShipType { get; set; }
        public string ShipType_Localised { get; set; }
        public long ShipID { get; set; }
        public int StoreShipID { get; set; }
        public string StoreOldShip { get; set; }
        public int StoreOldShipID { get; set; }
        public string SellOldShip { get; set; }
        public int SellShipID { get; set; }
    }
}