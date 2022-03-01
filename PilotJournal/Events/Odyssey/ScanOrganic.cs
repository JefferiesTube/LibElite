using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Odyssey
{
    public enum ScanType { Log, Sample, Analyse }

    [EventType("ScanOrganic")]
    public class ScanOrganic : EventBase
    {
        public ScanType ScanType { get; set; }
        public string Genus { get; set; }
        public string Genus_Localised { get; set; }
        public string Species { get; set; }
        public string Species_Localised { get; set; }
        public long SystemAddress { get; set; }
        public int Body { get; set; }
    }
}