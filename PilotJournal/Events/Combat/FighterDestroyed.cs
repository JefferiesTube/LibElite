using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Combat
{
    [EventType("FighterDestroyed")]
    public class FighterDestroyed : EventBase
    {
        public int ID { get; set; }
    }
}