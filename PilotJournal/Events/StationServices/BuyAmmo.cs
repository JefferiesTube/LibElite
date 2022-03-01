using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("BuyAmmo")]
    public class BuyAmmo : EventBase
    {
        public int Cost { get; set; }
    }
}