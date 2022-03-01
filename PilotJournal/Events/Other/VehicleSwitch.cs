using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("VehicleSwitch")]
    public class VehicleSwitch : EventBase
    {
        public VehicleSwitchTarget To { get; set; }
    }
}