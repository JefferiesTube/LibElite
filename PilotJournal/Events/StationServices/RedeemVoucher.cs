using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    [EventType("RedeemVoucher")]
    public class RedeemVoucher : EventBase
    {
        public VoucherType? Type { get; set; }
        public int Amount { get; set; }
        public string Faction { get; set; }
        public float BrokerPercentage { get; set; }
        public BountyFactionEntry[] Factions { get; set; }
    }

    public class BountyFactionEntry
    {
        public string Faction { get; set; }
        public int Amount { get; set; }
    }
}