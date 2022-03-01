using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Trade
{
    [EventType("CollectCargo")]
    public class CollectCargo : EventBase
    {
        public string Type { get; set; }
        public string Type_Localised { get; set; }
        public bool Stolen { get; set; }
        public int MissionID { get; set; }
    }
}