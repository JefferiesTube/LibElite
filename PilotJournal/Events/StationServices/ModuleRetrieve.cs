using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("ModuleRetrieve")]
    public class ModuleRetrieve : EventBase
    {
        public long MarketID { get; set; }
        public string Slot { get; set; }
        public string Ship { get; set; }
        public long ShipID { get; set; }
        public string RetrievedItem { get; set; }
        public string RetrievedItem_Localised { get; set; }
        public bool Hot { get; set; }
        public string EngineerModifications { get; set; }
        public string Level { get; set; }
        public string Quality { get; set; }
        public string SwapOutItem { get; set; }
        public string SwapOutItem_Localised { get; set; }
        public int Cost { get; set; }
    }
}