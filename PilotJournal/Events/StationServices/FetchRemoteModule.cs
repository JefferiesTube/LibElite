using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("FetchRemoteModule")]
    public class FetchRemoteModule : EventBase
    {
        public int StorageSlot { get; set; }
        public string StoredItem { get; set; }
        public string StoredItem_Localised { get; set; }
        public int ServerId { get; set; }
        public long TransferCost { get; set; }
        public string Ship { get; set; }
        public long ShipId { get; set; }
        public long TransferTime { get; set; }
    }
}