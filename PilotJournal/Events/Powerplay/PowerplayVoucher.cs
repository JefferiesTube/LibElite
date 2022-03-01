using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Powerplay
{
    [EventType("PowerplayVoucher")]
    public class PowerplayVoucher : EventBase
    {
        public string Power { get; set; }
        public string[] Systems { get; set; }
    }
}