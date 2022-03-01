using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("Scanned")]
    public class Scanned : EventBase
    {
        public ScanType ScanType { get; set; }
    }
}