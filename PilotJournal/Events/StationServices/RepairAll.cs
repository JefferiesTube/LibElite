using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("RepairAll")]
    public class RepairAll : EventBase
    {
        public int Cost { get; set; }
    }
}