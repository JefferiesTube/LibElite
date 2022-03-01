using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Travel
{
    [EventType("Touchdown")]
    public class Touchdown : EventBase
    {
        public string StarSystem { get; set; }
        public long SystemAddress { get; set; }
        public string Body { get; set; }
        public int BodyID { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool PlayerControlled { get; set; }
        public string NearestDestination { get; set; }
        public string NearestDestination_Localised { get; set; }
        public bool Taxi { get; set; }
        public bool Multicrew { get; set; }
        public bool OnStation { get; set; }
        public bool OnPlanet { get; set; }
    }
}