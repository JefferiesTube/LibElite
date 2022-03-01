using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Combat
{
    [EventType("HeatDamage")]
    public class HeatDamage : EventBase
    {
        public int ID { get; set; }
    }
}