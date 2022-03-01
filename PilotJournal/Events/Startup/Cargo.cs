using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Startup
{
    public class CargoEntry
    {
        public string Name { get; set; }
        public string Name_Localised { get; set; }
        public int Count { get; set; }
        public int Stolen { get; set; }
        public int MissionID { get; set; }
    }

    [EventType("Cargo")]
    public class Cargo : EventBase
    {
        public Vessel Vessel { get; set; }

        public int Count { get; set; }

        public CargoEntry[] Inventory { get; set; }
    }
}