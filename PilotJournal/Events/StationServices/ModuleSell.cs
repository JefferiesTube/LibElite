using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("ModuleSell")]
    public class ModuleSell : EventBase
    {
        public long MarketID { get; set; }
        public string Slot { get; set; }
        public string Ship { get; set; }
        public long ShipID { get; set; }
        public string RetrievedItem { get; set; }
        public bool Hot { get; set; }
        public string SellItem { get; set; }
        public string SellItem_Localised { get; set; }
        public long SellPrice { get; set; }
        public string EngineerModifications { get; set; }
        public string Level { get; set; }
        public string Quality { get; set; }
        public string SwapOutItem { get; set; }
        public int Cost { get; set; }
    }
}