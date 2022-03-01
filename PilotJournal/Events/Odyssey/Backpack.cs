using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Odyssey
{
    [EventType("Backpack")]
    public class Backpack : EventBase
    {
        public BackpackItem[] Items { get; set; }
        public BackpackItem[] Components { get; set; }
        public BackpackItem[] Consumables { get; set; }
        public BackpackItem[] Data { get; set; }
    }

    [EventType("BackpackMaterials")]
    public class BackpackMaterials : EventBase
    {
        public BackpackItem[] Items { get; set; }
        public BackpackItem[] Components { get; set; }
        public BackpackItem[] Consumables { get; set; }
        public BackpackItem[] Data { get; set; }
    }

    public class BackpackItem
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Name_Localised { get; set; }
        public long OwnerID { get; set; }
        public long? MissionID { get; set; }
        public int Count { get; set; }
    }
}