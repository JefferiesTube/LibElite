using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Odyssey
{
    [EventType("Embark")]
    public class Embark : EventBase
    {
        public bool SRV { get; set; }
        public bool Taxi { get; set; }
        public bool Multicrew { get; set; }
        public long? ID { get; set; }
        public string StarSystem { get; set; }
        public string SystemAddress { get; set; }
        public string Body { get; set; }
        public long BodyID { get; set; }
        public bool OnStation { get; set; }
        public bool OnPlanet { get; set; }
        public string StationName { get; set; }
        public StationType StationType { get; set; }
        public long? MarketID { get; set; }
    }
}