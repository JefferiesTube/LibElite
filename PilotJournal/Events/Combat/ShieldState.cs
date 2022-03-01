using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Combat
{
    [EventType("ShieldState")]
    public class ShieldState : EventBase
    {
        public bool ShieldsUp { get; set; }
    }
}