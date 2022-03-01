using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Exploration
{
    [EventType("NavBeaconScan")]
    public class NavBeaconScan : EventBase
    {
        public int NumBodies { get; set; }
        public long SystemAddress { get; set; }
    }
}