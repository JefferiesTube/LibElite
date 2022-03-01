using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Exploration
{
    [EventType("FSSSignalDiscovered")]
    public class FSSSignalDiscovered : EventBase
    {
        public string SignalName { get; set; }
        public string SignalName_Localised { get; set; }
        public string SpawningState { get; set; }
        public string SpawningState_Localised { get; set; }
        public string SpawningFaction { get; set; }
        public string SpawningFaction_Localised { get; set; }
        public long TimeRemaining { get; set; }
        public long SystemAddress { get; set; }
        public int ThreatLevel { get; set; }
        public string USSType { get; set; }
        public string USSType_Localised { get; set; }
        public bool IsStation { get; set; }
    }
}