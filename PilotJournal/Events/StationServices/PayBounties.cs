using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("PayBounties")]
    public class PayBounties : EventBase
    {
        public int Amount { get; set; }
        public float BrokerPercentage { get; set; }
        public bool AllFines { get; set; }
        public string Faction { get; set; }
        public string Faction_Localised { get; set; }
        public long ShipID { get; set; }
    }
}