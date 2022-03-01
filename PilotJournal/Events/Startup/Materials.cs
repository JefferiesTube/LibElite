using LibElite.PilotJournal.Attributes;
using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Startup
{
    public class MaterialEntry
    {
        public string Name { get; set; }
        public string Name_Localised { get; set; }
        public int Count { get; set; }
    }

    [EventType("Materials")]
    [AffectsMaterials]
    public class Materials : EventBase
    {
        public string FID { get; set; }
        public string Name { get; set; }
        public string Name_Localised { get; set; }
        public MaterialEntry[] Raw { get; set; }
        public MaterialEntry[] Manufactured { get; set; }
        public MaterialEntry[] Encoded { get; set; }
    }
}