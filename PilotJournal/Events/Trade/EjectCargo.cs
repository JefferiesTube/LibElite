using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Trade
{
    [EventType("EjectCargo")]
    public class EjectCargo : EventBase
    {
        public string Type { get; set; }
        public string Type_Localised { get; set; }
        public int Count { get; set; }
        public int MissionID { get; set; }
        public bool Abandoned { get; set; }
        public string PowerplayOrigin { get; set; }
    }
}