using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Odyssey
{
    [EventType("DropShipDeploy")]
    public class DropShipDeploy : EventBase
    {
        public string StarSystem { get; set; }
        public long SystemAddress { get; set; }
        public string Body { get; set; }
        public long BodyID { get; set; }
        public bool OnStation { get; set; }
        public bool OnPlanet { get; set; }
    }
}