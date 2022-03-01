using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.StationServices
{
    /// <summary>
    /// When repairing the ship
    /// </summary>
    [EventType("Repair")]
    public class Repair : EventBase
    {
        /// <summary>
        /// all, wear, hull, paint, or name of module 
        /// </summary>
        public string Item { get; set; }
        /// <summary>
        /// cost of repair 
        /// </summary>
        public int Cost { get; set; }
        /// <summary>
        /// When repairing on a FleetCarrier, you can now get a list of the modules repaired
        /// </summary>
        public string[] Items;
    }
}