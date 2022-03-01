using LibElite.PilotJournal.Converter;
using LibElite.PilotJournal.Events.BaseClasses;
using LibElite.PilotJournal.Events.Travel;

namespace LibElite.PilotJournal.Events.FleetCarriers
{
    /// <summary>
    /// This is similar to FSDJump and Location, but it is written if the player is online and docked at a fleet
    /// carrier when the carrier jumps.Note it does not include the distance jumped, or fuel used.
    /// </summary>
    [EventType("CarrierJump")]
    public class CarrierJump : JumpEvent
    {
        public string[] Powers;
        public string PowerplayState;
        public LocalFaction[] Factions;
        public SystemFaction SystemFaction;
        public Conflict[] Conflicts;
    }
}
