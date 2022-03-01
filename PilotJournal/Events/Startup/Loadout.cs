using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Startup
{
    [EventType("Loadout")]
    public class Loadout : EventBase
    {
        public string Ship { get; set; }
        public long ShipID { get; set; }
        public string ShipName { get; set; }
        public string ShipIdent { get; set; }
        public double HullValue { get; set; }
        public double ModulesValue { get; set; }
        public double HullHealth { get; set; }
        public double UnladenMass { get; set; }
        public FuelCapacity FuelCapacity { get; set; }
        public int CargoCapacity { get; set; }
        public double MaxJumpRange { get; set; }
        public long Rebuy { get; set; }
        public bool Hot { get; set; }
        public Module[] Modules { get; set; }
    }

    public class FuelCapacity
    {
        public double Main { get; set; }
        public double Reserve { get; set; }
    }

    public class Module
    {
        public string Slot { get; set; }
        public string Item { get; set; }
        public bool On { get; set; }
        public int Priority { get; set; }
        public double Health { get; set; }
        public double Value { get; set; }
        public int AmmoInClip { get; set; }
        public int AmmoInHopper { get; set; }
        public ModuleEngineering Engineering { get; set; }
        public string EngineerBlueprint { get; set; }
        public int EngineerLevel { get; set; }
    }

    public class ModuleEngineering
    {
        public string EngineerID { get; set; }
        public string Engineer { get; set; }
        public string BlueprintID { get; set; }
        public string BlueprintName { get; set; }
        public int Level { get; set; }
        public double Quality { get; set; }
        public string ExperimentalEffect { get; set; }
        public string ExperimentalEffect_Localised { get; set; }
        public ModuleEngineeringModification[] Modifiers { get; set; }
    }

    public class ModuleEngineeringModification
    {
        public string Label { get; set; }
        public double Value { get; set; }
        public double OriginalValue { get; set; }
        public bool LessIsGood { get; set; }
        public string ValueStr { get; set; }
        public string ValueStr_Localised { get; set; }
    }
}