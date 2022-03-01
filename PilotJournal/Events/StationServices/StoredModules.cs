using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("StoredModules")]
    public class StoredModules : EventBase
    {
        public long MarketID { get; set; }
        public string ShipType { get; set; }
        public long ShipID { get; set; }
        public string System { get; set; }
        public string StationName { get; set; }
        public string StarSystem { get; set; }
        public long ShipMarketID { get; set; }
        public float Distance { get; set; }
        public int TransferPrice { get; set; }
        public int TransferTime { get; set; }
        public StoredModuleEntry[] Items { get; set; }
    }

    public class StoredModuleEntry
    {
        public string Name{ get; set; }
        public string Name_Localised { get; set; }
        public string StarSystem{ get; set; }
        public long MarketID{ get; set; }
        public string StorageSlot{ get; set; }
        public int TransferCost{ get; set; }
        public int TransferTime{ get; set; }
        public bool Hot{ get; set; }
        public string EngineerModifications{ get; set; }
        public string Level{ get; set; }
        public string Quality{ get; set; }
        public bool InTransit{ get; set; }
        public int BuyPrice { get; set; }
    }
}