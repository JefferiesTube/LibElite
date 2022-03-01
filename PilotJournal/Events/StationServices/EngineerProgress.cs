using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("EngineerProgress")]
    public class EngineerProgress : EventBase
    {
        public string Engineer { get; set; }
        public string EngineerID { get; set; }
        public int Rank { get; set; }
        public float RankProgress { get; set; }
        public EngineerProgressStage Progress { get; set; }
        
        public EngineerProgressEntry[] Engineers { get; set; }
    }

    public class EngineerProgressEntry
    {
        public string Engineer { get; set; }
        public string EngineerID { get; set; }
        public int Rank { get; set; }
        public float RankProgress { get; set; }
        public EngineerProgressStage Progress { get; set; }
    }
}