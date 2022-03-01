using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Powerplay
{
    [EventType("PowerplayCollect")]
    public class PowerplayCollect : EventBase
    {
        public string Power { get; set; }

        public string Type { get; set; }
        public string Type_Localised { get; set; }
        public int Count { get; set; }
    }
}