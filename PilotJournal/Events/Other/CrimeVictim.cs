using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Other
{
    [EventType("CrimeVictim")]
    public class CrimeVictim : EventBase
    {
        public string Offender;
        public Crime CrimeType;
        public int Fine;
        public int Bounty;
    }
}