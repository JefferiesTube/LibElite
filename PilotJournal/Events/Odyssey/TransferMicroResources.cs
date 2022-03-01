using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Odyssey
{
    [EventType("TransferMicroResources")]
    public class TransferMicroResources : EventBase
    {
        public ResourceTransfer[] Transfers { get; set; }
    }

    public class ResourceTransfer
    {
        public string Name { get; set; }
        public string Name_Localised { get; set; }
        public string Category { get; set; }
        public int Count { get; set; }
        public string Direction { get; set; }
    }
}