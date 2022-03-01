using LibElite.PilotJournal.Converter;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace LibElite.PilotJournal.Events.FleetCarriers
{
    [EventType("CarrierDockingPermission")]
    public class CarrierDockingPermission : CarrierEventBase
    {
        [J("CarrierID")] public long CarrierID { get; set; }
        [J("DockingAccess")] public DockingAccess DockingAccess { get; set; }
        [J("AllowNotorious")] public bool AllowNotorious { get; set; }
    }
}