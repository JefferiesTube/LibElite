using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("SetUserShipName")]
    public class SetUserShipName : EventBase
    {
        public string Ship { get; set; }
        public long ShipID { get; set; }
        public string UserShipName { get; set; }
        public string UserShipId { get; set; }
    }
}