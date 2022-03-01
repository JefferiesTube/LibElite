using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Startup
{
    [EventType("NewCommander")]
    public class NewCommander : EventBase
    {
        public string Name { get; set; }
        public string FID { get; set; }
        public string Package { get; set; }
    }
}