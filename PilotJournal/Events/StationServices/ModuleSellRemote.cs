using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("ModuleSellRemote")]
    public class ModuleSellRemote : EventBase
    {
        public string StorageSlot { get; set; }
        public string SellItem { get; set; }
        public string SellItem_Localised { get; set; }
        public int ServerID { get; set; }
        public int SellPrice { get; set; }
        public string Ship { get; set; }
        public long ShipID { get; set; }
    }
}