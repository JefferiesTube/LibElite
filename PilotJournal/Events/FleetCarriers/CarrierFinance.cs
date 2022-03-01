using LibElite.PilotJournal.Converter;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace LibElite.PilotJournal.Events.FleetCarriers
{
    /// <summary>
    /// Change to tax rate or reserve 
    /// </summary>
    [EventType("CarrierFinance")]
    public class CarrierFinance : CarrierEventBase
    {
        [J("CarrierID")] public long CarrierID { get; set; }
        [J("TaxRate")] public double TaxRate { get; set; }
        [J("CarrierBalance")] public long CarrierBalance { get; set; }
        [J("ReserveBalance")] public long ReserveBalance { get; set; }
        [J("AvailableBalance")] public long AvailableBalance { get; set; }
        [J("ReservePercent")] public double ReservePercent { get; set; }
    }
}