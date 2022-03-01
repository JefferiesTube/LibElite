using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("ShipyardNew")]
    public class ShipyardNew : EventBase
    {
        public string ShipType { get; set; }
        public string ShipType_Localised { get; set; }
        public int NewShipID { get; set; }
    }
}