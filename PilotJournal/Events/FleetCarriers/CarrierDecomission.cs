using LibElite.PilotJournal.Converter;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace LibElite.PilotJournal.Events.FleetCarriers
{
    /// <summary>
    /// At the time the player requests the jump, not the jump itself 
    /// </summary>
    [EventType("CarrierDecomission")]
    public class CarrierDecomission : CarrierEventBase
    {
        [J("ScrapRefund")] public long ScrapRefund { get; set; }
        [J("ScrapTime")] public long ScrapTime { get; set; }
    }
}