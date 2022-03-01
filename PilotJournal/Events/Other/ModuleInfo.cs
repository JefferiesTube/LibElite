using LibElite.PilotJournal.Converter;
using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;
using N = Newtonsoft.Json.NullValueHandling;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("ModuleInfo")]
    public class ModuleInfo : EventBase
    {
        public static ModuleInfo Last { get; set; }

        public static event Action<ModuleInfo> OnChanged;

        [J("Modules")] public Module[] Modules { get; set; }

        public static void Update(ModuleInfo newState)
        {
            Last = newState;
            OnChanged?.Invoke(Last);
        }
    }

    public class Module
    {
        [J("Slot")] public string Slot { get; set; }
        [J("Item")] public string Item { get; set; }
        [J("Power")] public double Power { get; set; }
        [J("Priority", NullValueHandling = N.Ignore)] public long? Priority { get; set; }
    }
}