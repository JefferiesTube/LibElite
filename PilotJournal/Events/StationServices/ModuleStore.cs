using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("ModuleStore")]
    public class ModuleStore : EventBase
    {
        public long MarketID { get; set; }
        public string Slot { get; set; }
        public string Ship { get; set; }
        public long ShipID { get; set; }
        public string StoredItem { get; set; }
        public string StoredItem_Localised { get; set; }
        public bool Hot { get; set; }
        public string EngineerModifications { get; set; }
        public string Level { get; set; }
        public string Quality { get; set; }
        public string ReplacementItem { get; set; }
        public int Cost { get; set; }
    }
}