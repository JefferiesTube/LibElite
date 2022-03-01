using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Powerplay
{
    [EventType("PowerplayDefect")]
    public class PowerplayDefect : EventBase
    {
        public string FromPower { get; set; }
        public string ToPower { get; set; }
    }
}