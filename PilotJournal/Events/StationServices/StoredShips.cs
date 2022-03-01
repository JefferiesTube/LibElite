using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("StoredShips")]
    public class StoredShips : EventBase
    {
        public long MarketID { get; set; }
        public string StationName { get; set; }
        public string StarSystem { get; set; }
        public StoredShipEntry[] ShipsHere { get; set; }
        public StoredShipEntry[] Shipsremote { get; set; }
    }

    public class StoredShipEntry
    {
        public long ShipID { get; set; }
        public string ShipType { get; set; }
        public string ShipType_Localised { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public bool Hot { get; set; }
        public bool InTransit { get; set; }
        public string StarSystem { get; set; }
        public long ShipMarketID { get; set; }
        public int TransferPrice { get; set; }
        public int TransferType { get; set; }
        public int TransferTime { get; set; }
    }
}