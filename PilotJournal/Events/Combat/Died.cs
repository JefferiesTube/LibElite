using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Combat
{
    [EventType("Died")]
    public class Died : EventBase
    {
        public string KillerName { get; set; }
        public string KillerName_Localised { get; set; }
        public string KillerShip { get; set; }
        public string KillerRank { get; set; }
        public WingKiller[] Killers { get; set; }
    }

    public class WingKiller
    {
        public string Name { get; set; }
        public string Ship { get; set; }
        public string Rank { get; set; }
    }
}