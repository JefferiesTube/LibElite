using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Travel
{
    [EventType("SupercruiseExit")]
    public class SupercruiseExit : EventBase
    {
        public string Starsystem { get; set; }
        public string Body { get; set; }
        public long BodyID { get; set; }
        public long SystemAddress { get; set; }
        public string BodyType { get; set; }
        public bool Taxi { get; set; }
        public bool Multicrew { get; set; }
    }
}