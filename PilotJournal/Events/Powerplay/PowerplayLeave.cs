using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Powerplay
{
    [EventType("PowerplayLeave")]
    public class PowerplayLeave : EventBase
    {
        public string Power { get; set; }
    }
}