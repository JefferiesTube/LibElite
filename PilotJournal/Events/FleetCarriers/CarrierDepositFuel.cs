using LibElite.PilotJournal.Converter;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace LibElite.PilotJournal.Events.FleetCarriers
{
    /// <summary>
    /// Any player giving fuel to the carrier
    /// </summary>
    [EventType("CarrierDepositFuel")]
    public class CarrierDepositFuel : CarrierEventBase
    {
        [J("CarrierID")] public long CarrierID { get; set; }
        /// <summary>
        /// In tons
        /// </summary>
        [J("Amount")] public double Amount { get; set; }
        
        /// <summary>
        /// Total amount of fuel after donation 
        /// </summary>
        [J("Total")] public double Total { get; set; }
    }
}