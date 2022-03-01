using LibElite.PilotJournal.Attributes;
using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("EngineerCraft")]
    [AffectsMaterials]
    public class EngineerCraft : EventBase
    {
        public string EngineerName { get; set; }
        public string EngineerID { get; set; }
        public string Engineer { get; set; }
        public string Slot { get; set; }
        public string Module { get; set; }
        public string Blueprint { get; set; }
        public string BlueprintName { get; set; }
        public string BlueprintID { get; set; }
        public int Level { get; set; }
        public float Quality { get; set; }
        public string ApplyExperimentalEffect { get; set; }
        public string ExperimentalEffect { get; set; }
        public string ExperimentalEffect_Localised { get; set; }
        public EngineerIngredient[] Ingredients { get; set; }
        public EngineerModifier[] Modifiers { get; set; }
    }

    public class EngineerIngredient
    {
        public string Name { get; set; }
        public string Name_Localised { get; set; }
        public int Count { get; set; }
    }

    public class EngineerModifier
    {
        public string Label { get; set; }
        public float Value { get; set; }
        public string ValueStr { get; set; }
        public string ValueStr_Localised { get; set; }
        public float OriginalValue { get; set; }
        public int LessIsGood { get; set; }
    }
}