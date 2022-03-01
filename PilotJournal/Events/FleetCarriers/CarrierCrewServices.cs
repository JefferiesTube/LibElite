using LibElite.PilotJournal.Converter;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace LibElite.PilotJournal.Events.FleetCarriers
{
    [EventType("CarrierCrewServices")]
    public class CarrierCrewServices : CarrierEventBase
    {
        [J("CarrierID")] public long CarrierID { get; set; }
        [J("CrewRole")] public string CrewRole { get; set; }
        [J("Operation")] public CarrierCrewOperation Operation { get; set; }
        [J("CrewName")] public string CrewName { get; set; }
    }
}