using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Startup
{
    [EventType("ClearSavedGame")]
    public class ClearSavedGame : EventBase
    {
        public string Name { get; set; }
        public string FID { get; set; }
    }
}