using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("PayFines")]
    public class PayFines : EventBase
    {
        public int Amount { get; set; }
        public float BrokerPercentage { get; set; }
        public bool AllFines { get; set; }
        public string Faction { get; set; }
        public long ShipID { get; set; }
    }
}