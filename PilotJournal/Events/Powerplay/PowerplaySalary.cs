using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Powerplay
{
    [EventType("PowerplaySalary")]
    public class PowerplaySalary : EventBase
    {
        public string Power { get; set; }
        public int Amount { get; set; }
    }
}