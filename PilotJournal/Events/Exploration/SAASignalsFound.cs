using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Exploration
{
    [EventType("SAASignalsFound")]
    public class SAASignalsFound : EventBase
    {
        public string BodyName { get; set; }
        public long SystemAddress { get; set; }
        public int BodyID { get; set; }
        public Signal[] Signals { get; set; }
    }

    public class Signal
    {
        public string Type { get; set; }
        public string Type_Localised { get; set; }
        public int Count { get; set; }
    }
}