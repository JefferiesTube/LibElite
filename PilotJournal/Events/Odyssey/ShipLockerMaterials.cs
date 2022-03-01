using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Odyssey
{
    [EventType("ShipLockerMaterials")]
    public class ShipLockerMaterials : EventBase
    {
        public ShipLockerEntry[] Items { get; set; }
        public ShipLockerEntry[] Components { get; set; }
        public ShipLockerEntry[] Consumables { get; set; }
        public ShipLockerEntry[] Data { get; set; }
    }

    public class ShipLockerEntry
    {
        public string Name { get; set; }
        public string Name_Localised { get; set; }
        public long OwnerID { get; set; }
        public long? MissionID { get; set; }
        public int Count { get; set; }
    }
}