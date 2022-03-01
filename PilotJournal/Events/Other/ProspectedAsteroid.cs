using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("ProspectedAsteroid")]
    public class ProspectedAsteroid : EventBase
    {
        public Material[] Materials { get; set; }
        public string Content { get; set; }
        public string Content_Localised { get; set; }
        public double Remaining { get; set; }
        public string MotherlodeMaterial { get; set; }
        public string MotherlodeMaterial_Localised { get; set; }
    }

    public class Material
    {
        public string Name { get; set; }
        public double Proportion { get; set; }
        public string Name_Localised { get; set; }
    }
}