using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Odyssey
{
    [EventType("BackpackChange")]
    public class BackpackChange : EventBase
    {
        public BackpackItem[] Added { get; set; }
        public BackpackItem[] Removed { get; set; }
    }
}