using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("EngineerContribution")]
    public class EngineerContribution : EventBase
    {
        public string EngineerName { get; set; }
        public string Engineer { get; set; }
        public string EngineerID { get; set; }
        public EngineerContributionType Type { get; set; }
        public string Commodity { get; set; }
        public string Commodity_Localised { get; set; }
        public string Material { get; set; }
        public string Material_Localised { get; set; }
        public string Faction { get; set; }
        public int Quantity { get; set; }
        public int TotalQuantity { get; set; }
    }
}