using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    /// <summary>
    /// When transferring cargo between ship and fleet carrier, or between ship and SRV
    /// </summary>
    [EventType("CargoTransfer")]
    public class CargoTransfer : EventBase
    {
        public CargoTransferEntry[] Transfers;
    }

    public class CargoTransferEntry
    {
        public string Type;
        public int Count;
        public string Direction;
    }
}