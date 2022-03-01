using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("DatalinkVoucher")]
    public class DatalinkVoucher : EventBase
    {
        public int Reward { get; set; }
        public string VictimFaction { get; set; }
        public string PayeeFaction { get; set; }
    }
}