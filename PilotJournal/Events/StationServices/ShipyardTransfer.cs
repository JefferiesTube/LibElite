using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("ShipyardTransfer")]
    public class ShipyardTransfer : EventBase
    {
        public long MarketID { get; set; }
        public string ShipType { get; set; }
        public string ShipType_Localised { get; set; }
        public long ShipID { get; set; }
        public string System { get; set; }
        public long ShipMarketID { get; set; }
        public float Distance { get; set; }
        public int TransferPrice { get; set; }
        public int TransferTime { get; set; }
    }
}