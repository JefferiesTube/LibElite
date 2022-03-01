using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Odyssey
{
    [EventType("CancelTaxi")]
    public class CancelTaxi : EventBase
    {
        public int Refund { get; set; }
    }
}