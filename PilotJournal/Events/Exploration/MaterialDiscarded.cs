using LibElite.PilotJournal.Attributes;
using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Exploration
{
    [EventType("MaterialDiscarded")]
    [AffectsMaterials]
    public class MaterialDiscarded : EventBase
    {
        public MaterialCategory Category { get; set; }
        public string Name { get; set; }
        public string Name_Localised { get; set; }
        public int Count { get; set; }
    }
}