using LibElite.PilotJournal.Converter;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace LibElite.PilotJournal.Events.FleetCarriers
{
    [EventType("CarrierModulePack")]
    public class CarrierModulePack : CarrierEventBase
    {
        [J("Operation")] public string Operation { get; set; }
        [J("PackTheme")] public string PackTheme { get; set; }
        [J("PackTier")] public long PackTier { get; set; }
        [J("Cost")] public long Cost { get; set; }
    }
}