using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Combat
{
    [EventType("HullDamage")]
    public class HullDamage : EventBase
    {
        public double Health;
        public bool PlayerPilot;
        public bool Fighter;
    }
}