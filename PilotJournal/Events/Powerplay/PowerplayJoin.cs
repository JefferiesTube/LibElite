using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Powerplay
{
    [EventType("PowerplayJoin")]
    public class PowerplayJoin : EventBase
    {
        public string Power { get; set; }
    }
}