using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("ModuleBuy")]
    public class ModuleBuy : EventBase
    {
        public long MarketID { get; set; }
        public string Slot { get; set; }
        public string BuyItem { get; set; }
        public string BuyItem_Localised { get; set; }
        public int BuyPrice { get; set; }
        public string Ship { get; set; }
        public long ShipID { get; set; }
        public string StoredItem { get; set; }
        public string StoredItem_Localised { get; set; }
        public string SellItem { get; set; }
        public string SellItem_Localised { get; set; }
        public int SellPrice { get; set; }
    }
}