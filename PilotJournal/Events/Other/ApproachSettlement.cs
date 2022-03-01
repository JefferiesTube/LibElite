using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("ApproachSettlement")]
    public class ApproachSettlement : EventBase
    {
        public string Name { get; set; }
        public string Name_Localised { get; set; }
        public long MarketID { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public long SystemAddress { get; set; }
        public long BodyID { get; set; }
        public string BodyName { get; set; }
    }
}