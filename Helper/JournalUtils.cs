using System;
using System.Linq;
using LibElite.PilotJournal;
using LibElite.PilotJournal.Events.Exploration;

namespace LibElite.Helper
{
    public static class JournalUtils
    {
        public static bool HasSoldSystemData(JournalReader reader, string systemName)
        {
            lock (reader.Events)
            {
                return reader.Events.OfType<MultiSellExplorationData>().Any(ed => ed.Discovered.Any(d => d.SystemName.Equals(systemName, StringComparison.InvariantCultureIgnoreCase)))
                       || reader.Events.OfType<SellExplorationData>().Any(ed => ed.Systems.Any(se => se.Equals(systemName, StringComparison.InvariantCultureIgnoreCase)));
            }
        }
    }
}