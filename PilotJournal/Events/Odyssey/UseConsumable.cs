using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Odyssey
{
    [EventType("UseConsumable")]
    public class UseConsumable : EventBase
    {
        public string Name { get; set; }
        public string Name_Localised { get; set; }
        public string Type { get; set; }
    }
}