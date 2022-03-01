using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Exploration
{
    [EventType("MaterialDiscovered")]
    public class MaterialDiscovered : EventBase
    {
        public MaterialCategory Category { get; set; }
        public string Name { get; set; }
        public string Name_Localised { get; set; }
        public int DiscoveryNumber { get; set; }
    }
}