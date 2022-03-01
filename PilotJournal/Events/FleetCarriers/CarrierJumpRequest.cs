using LibElite.PilotJournal.Converter;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace LibElite.PilotJournal.Events.FleetCarriers
{
    /// <summary>
    /// At the time the player requests the jump, not the jump itself 
    /// </summary>
    [EventType("CarrierJumpRequest")]
    public class CarrierJumpRequest : CarrierEventBase
    {
        [J("SystemName")] public string SystemName { get; set; }
        [J("SystemAddress")] public long SystemAddress { get; set; }
        [J("CarrierID")] public long CarrierID { get; set; }
        [J("Body")] public string Body { get; set; }
        [J("BodyID")] public long BodyID { get; set; }
    }
}