using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Odyssey
{
    [EventType("RenameSuitLoadout")]
    public class RenameSuitLoadout : EventBase
    {
        public long SuitID { get; set; }
        public string SuitName { get; set; }
        public long LoadoutID { get; set; }
        public string LoadoutName { get; set; }
    }
}