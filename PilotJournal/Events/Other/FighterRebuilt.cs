using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("FighterRebuilt")]
    public class FighterRebuilt : EventBase
    {
        public string Loadout { get; set; }
        public int ID { get; set; }
    }
}