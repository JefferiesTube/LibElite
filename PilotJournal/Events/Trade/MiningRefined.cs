using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Trade
{
    [EventType("MiningRefined")]
    public class MiningRefined : EventBase
    {
        public string Type { get; set; }
        public string Type_Localised { get; set; }
    }
}