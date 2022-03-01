using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Exploration
{
    [EventType("SAAScanComplete")]
    public class SAAScanComplete : EventBase
    {
        public string BodyName { get; set; }
        public int BodyID { get; set; }
        public int ProbesUsed { get; set; }
        public int EfficiencyTarget { get; set; }
        public long SystemAddress { get; set; }
    }
}