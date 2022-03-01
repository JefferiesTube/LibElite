using LibElite.PilotJournal.Attributes;
using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("Synthesis")]
    [AffectsMaterials]
    public class Synthesis : EventBase
    {
        public string Name { get; set; }
        public SynthesisMaterialEntry[] Materials { get; set; }
    }

    public class SynthesisMaterialEntry
    {
        public string Name;
        public string Name_Localised;
        public int Count;
    }
}