using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("RefuelPartial")]
    public class RefuelPartial : EventBase
    {
        public int Cost { get; set; }
        public float Amount { get; set; }
    }
}