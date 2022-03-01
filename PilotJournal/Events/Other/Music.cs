using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("Music")]
    public class Music : EventBase
    {
        public string MusicTrack { get; set; }
    }
}