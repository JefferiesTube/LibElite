using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("CommitCrime")]
    public class CommitCrime : EventBase
    {
        public Crime CrimeType { get; set; }
        public string Faction { get; set; }
        public string Victim { get; set; }
        public string Victim_Localised { get; set; }
        public int Fine { get; set; }
        public int Bounty { get; set; }
    }
}