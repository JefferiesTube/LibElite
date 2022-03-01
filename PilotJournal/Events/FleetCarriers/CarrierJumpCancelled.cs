using LibElite.PilotJournal.Converter;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace LibElite.PilotJournal.Events.FleetCarriers
{
    /// <summary>
    /// At the time the player requests the jump, not the jump itself 
    /// </summary>
    [EventType("CarrierJumpCancelled")]
    public class CarrierJumpCancelled : CarrierEventBase
    {
        [J("CarrierID")] public long CarrierID { get; set; }
    }
}