using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("JetConeBoost")]
    public class JetConeBoost : EventBase
    {
        public float BoostValue { get; set; }
    }
}