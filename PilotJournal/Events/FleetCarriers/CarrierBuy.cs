using LibElite.PilotJournal.Converter;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace LibElite.PilotJournal.Events.FleetCarriers
{
    /// <summary>
    /// Player has bought a fleet carrier
    /// </summary>
    [EventType("CarrierBuy")]
    public class CarrierBuy : CarrierEventBase
    {
        [J("CarrierID")] public long CarrierID { get; set; }
        [J("BoughtAtMarket")] public long BoughtAtMarket { get; set; }
        [J("Location")] public string Location { get; set; }
        [J("SystemAddress")] public long SystemAddress { get; set; }
        [J("Price")] public long Price { get; set; }
        [J("Variant")] public string Variant { get; set; }
        [J("Callsign")] public string Callsign { get; set; }
    }
}