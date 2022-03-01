using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("CargoDepot")]
    public class CargoDepot : EventBase
    {
        public int MissionID { get; set; }
        public CargoDepotUpdateType UpdateType { get; set; }
        public string CargoType { get; set; }
        public string CargoType_Localised { get; set; }
        public int Count { get; set; }
        public long StartMarketID { get; set; }
        public long EndMarketID { get; set; }
        public int ItemsCollected { get; set; }
        public int ItemsDelivered { get; set; }
        public int TotalItemsToDeliver { get; set; }
        public float Progress { get; set; }
    }
}