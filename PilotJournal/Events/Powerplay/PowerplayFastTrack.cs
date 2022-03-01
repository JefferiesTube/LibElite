using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Powerplay
{
    [EventType("PowerplayFastTrack")]
    public class PowerplayFastTrack : EventBase
    {
        public string Power { get; set; }
        public int Cost { get; set; }
    }
}