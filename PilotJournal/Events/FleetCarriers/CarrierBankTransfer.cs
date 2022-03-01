using LibElite.PilotJournal.Converter;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace LibElite.PilotJournal.Events.FleetCarriers
{
    [EventType("CarrierBankTransfer")]
    public class CarrierBankTransfer : CarrierEventBase
    {
        [J("CarrierID")] public long CarrierID { get; set; }
        [J("Deposit")]        public long Deposit { get; set; }
        [J("Withdraw")] public long Withdraw { get; set; }
        [J("PlayerBalance")]  public long PlayerBalance { get; set; }      
        [J("CarrierBalance")] public long CarrierBalance { get; set; }    
    }
}