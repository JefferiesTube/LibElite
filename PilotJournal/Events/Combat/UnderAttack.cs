using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Combat
{
    [EventType("UnderAttack")]
    public class UnderAttack : EventBase
    {
        public string Target { get; set; }
    }
}