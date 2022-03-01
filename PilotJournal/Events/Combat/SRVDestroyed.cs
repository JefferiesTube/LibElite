using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Combat
{
    [EventType("SRVDestroyed")]
    public class SRVDestroyed : EventBase
    {
        public int ID { get; set; }
    }
}