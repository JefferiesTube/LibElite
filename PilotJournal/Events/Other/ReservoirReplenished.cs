using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("ReservoirReplenished")]
    public class ReservoirReplenished : EventBase
    {
        public double FuelMain { get; set; }
        public double FuelReservoir { get; set; }
    }
}