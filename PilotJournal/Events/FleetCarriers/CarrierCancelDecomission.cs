using LibElite.PilotJournal.Converter;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace LibElite.PilotJournal.Events.FleetCarriers
{
    [EventType("CarrierCancelDecomission")]
    public class CarrierCancelDecomission : CarrierEventBase
    {
    }
}