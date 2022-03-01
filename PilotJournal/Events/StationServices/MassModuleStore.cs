using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("MassModuleStore")]
    public class MassModuleStore : EventBase
    {
        public long MarketID { get; set; }
        public string Ship { get; set; }
        public long ShipId { get; set; }
        public MassModuleStoreEntry[] Items { get; set; }
    }

    public class MassModuleStoreEntry
    {
        public int Slot { get; set; }
        public string Name { get; set; }
        public bool Hot { get; set; }
        public bool EngineerModifications { get; set; }
        public int Level { get; set; }
        public int Quality { get; set; }
    }
}