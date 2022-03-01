using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Startup
{
    [EventType("Commander")]
    public class Commander : EventBase
    {
        public string FID { get; set; }
        public string Name { get; set; }
    }
}