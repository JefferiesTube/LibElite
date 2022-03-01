using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Odyssey
{
    [EventType("BookDropship")]
    public class BookDropship : EventBase
    {
        public int Cost { get; set; }
        public string DestinationSystem { get; set; }
        public string DestinationLocation { get; set; }
    }
}