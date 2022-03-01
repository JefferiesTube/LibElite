using LibElite.PilotJournal.Converter;
using LibElite.PilotJournal.Events.BaseClasses;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace LibElite.PilotJournal.Events.FleetCarriers
{
    /// <summary>
    /// When owner opens carrier management 
    /// </summary>
    [EventType("CarrierStats")]
    public class CarrierStats : CarrierEventBase
    {
        [J("CarrierID")] public long CarrierId { get; set; }
        [J("Callsign")] public string Callsign { get; set; }
        [J("Name")] public string Name { get; set; }
        [J("DockingAccess")] public DockingAccess DockingAccess { get; set; }
        [J("AllowNotorious")] public bool AllowNotorious { get; set; }
        [J("FuelLevel")] public long FuelLevel { get; set; }
        [J("JumpRangeCurr")] public double JumpRangeCurr { get; set; }
        [J("JumpRangeMax")] public long JumpRangeMax { get; set; }
        [J("PendingDecommission")] public bool PendingDecommission { get; set; }
        [J("SpaceUsage")] public SpaceUsage SpaceUsage { get; set; }
        [J("Finance")] public Finance Finance { get; set; }
        [J("Crew")] public Crew[] Crew { get; set; }
        [J("ShipPacks")] public Pack[] ShipPacks { get; set; }
        [J("ModulePacks")] public Pack[] ModulePacks { get; set; }
    }

    public class Crew
    {
        [J("CrewRole")] public string CrewRole { get; set; }
        [J("Activated")] public bool Activated { get; set; }
        [J("Enabled")] public bool Enabled { get; set; }
        [J("CrewName")] public string CrewName { get; set; }
    }

    public class Finance
    {
        [J("CarrierBalance")] public long CarrierBalance { get; set; }
        [J("ReserveBalance")] public long ReserveBalance { get; set; }
        [J("AvailableBalance")] public long AvailableBalance { get; set; }
        [J("ReservePercent")] public long ReservePercent { get; set; }
        [J("TaxRate")] public long TaxRate { get; set; }
    }

    public class Pack
    {
        [J("PackTheme")] public string PackTheme { get; set; }
        [J("PackTier")] public long PackTier { get; set; }
    }

    public class SpaceUsage
    {
        [J("TotalCapacity")] public long TotalCapacity { get; set; }
        [J("Crew")] public long Crew { get; set; }
        [J("Cargo")] public long Cargo { get; set; }
        [J("CargoSpaceReserved")] public long CargoSpaceReserved { get; set; }
        [J("ShipPacks")] public long ShipPacks { get; set; }
        [J("ModulePacks")] public long ModulePacks { get; set; }
        [J("FreeSpace")] public long FreeSpace { get; set; }
    }
}