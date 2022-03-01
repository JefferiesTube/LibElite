using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Odyssey
{
    [EventType("DeleteSuitLoadout")]
    public class DeleteSuitLoadout : EventBase
    {
        public int SuitID { get; set; }
        public string SuitName { get; set; }
        public long LoadoutID { get; set; }
        public string LoadoutName { get; set; }
    }
}