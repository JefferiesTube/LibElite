using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Powerplay
{
    [EventType("PowerplayVote")]
    public class PowerplayVote : EventBase
    {
        public string Power { get; set; }
        public int Votes { get; set; }
        public string System { get; set; }
    }
}