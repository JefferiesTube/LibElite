using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Exploration
{
    [EventType("CodexEntry")]
    public class CodexEntry : EventBase
    {
        public int EntryID { get; set; }
        public string Name { get; set; }
        public string Name_Localised { get; set; }
        public string SubCategory { get; set; }
        public string SubCategory_Localised { get; set; }
        public string Category { get; set; }
        public string Category_Localised { get; set; }
        public string Region { get; set; }
        public string Region_Localised { get; set; }
        public string System { get; set; }
        public long SystemAddress { get; set; }
        public bool IsNewEntry { get; set; }
        public bool NewTraitsDiscovered { get; set; }
        public string NearestDestination { get; set; }
        public string NearestDestination_Localised { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }

        public string[] Traits { get; set; }
        public int VoucherAmount { get; set; }


    }
}