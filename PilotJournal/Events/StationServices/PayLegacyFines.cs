using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("PayLegacyFines")]
    public class PayLegacyFines : EventBase
    {
        public int Amount { get; set; }
        public float BrokerPercentage { get; set; }
    }
}