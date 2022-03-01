using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events
{
    [EventType("Fileheader")]
    public class FileHeader : EventBase
    {
        public int Part { get; set; }

        public string Language { get; set; }

        public string GameVersion { get; set; }
        public bool Odyssey { get; set; }

        public bool IsBetaVersion => GameVersion.Contains("Beta");

        public string Build { get; set; }
    }
}