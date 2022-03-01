using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Odyssey
{

    [EventType("SellOrganicData")]
    public class SellOrganicData : EventBase
    {
        public long MarketID { get; set; }
        public BioData[] BioData { get; set; }
    }

    public class BioData
    {
        public string Genus { get; set; }
        public string Genus_Localised { get; set; }
        public string Species { get; set; }
        public string Species_Localised { get; set; }
        public int Value { get; set; }
        public int Bonus { get; set; }
    }
}