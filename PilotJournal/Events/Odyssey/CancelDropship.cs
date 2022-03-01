using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Odyssey
{
    [EventType("CancelDropship")]
    public class CancelDropship : EventBase
    {
        public int Refund { get; set; }
    }
}