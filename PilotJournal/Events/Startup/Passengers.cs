using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Startup
{
    public class PassengerEntry
    {
        public int MissionID { get; set; }
        public string Type { get; set; }
        public bool VIP { get; set; }
        public bool Wanted { get; set; }
        public int Count { get; set; }
    }

    [EventType("Passengers")]
    public class Passengers : EventBase
    {
        public PassengerEntry[] Manifest { get; set; }
    }
}