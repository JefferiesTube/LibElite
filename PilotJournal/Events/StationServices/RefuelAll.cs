using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("RefuelAll")]
    public class RefuelAll : EventBase
    {
        public int Cost { get; set; }
        public float Amount { get; set; }
    }
}