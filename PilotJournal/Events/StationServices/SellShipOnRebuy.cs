using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("SellShipOnRebuy")]
    public class SellShipOnRebuy : EventBase
    {
        public string ShipType { get; set; }
        public string System { get; set; }
        public int SellShipID { get; set; }
        public int ShipPrice { get; set; }
    }
}