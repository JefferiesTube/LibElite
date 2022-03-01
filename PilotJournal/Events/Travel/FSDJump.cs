using LibElite.PilotJournal.Converter;
using LibElite.PilotJournal.Events.BaseClasses;

namespace LibElite.PilotJournal.Events.Travel
{
    [EventType("FSDJump")]
    public class FSDJump : JumpEvent
    {
        public double JumpDist { get; set; }
        public double FuelUsed { get; set; }
        public double FuelLevel { get; set; }
        public bool BoostUsed { get; set; }
        public SystemFaction SystemFaction { get; set; }
        public string FactionState { get; set; }
        public string[] Powers { get; set; }
        public string PowerplayState { get; set; }
        public bool Wanted { get; set; }
        public bool Taxi { get; set; }
        public bool Multicrew { get; set; }
        public LocalFaction[] Factions { get; set; }
        public Conflict[] Conflicts { get; set; }
    }

    public class LocalFaction
    {
        public string Name { get; set; }
        public string FactionState { get; set; }
        public string Government { get; set; }
        public double Influence { get; set; }
        public string Allegiance { get; set; }
        public string Happiness { get; set; }
        public string Happiness_Localised { get; set; }
        public double MyReputation { get; set; }
        public FactionState[] PendingStates;
        public FactionState[] RecoveringStates;
        public FactionState[] ActiveStates;
    }

    public class ConflictFaction
    {
        public string Name { get; set; }
        public string Stake { get; set; }
        public int WonDays { get; set; }
    }

    public class Conflict
    {
        public string WarType { get; set; }
        public string Status { get; set; }
        public ConflictFaction Faction1 { get; set; }
        public ConflictFaction Faction2 { get; set; }
    }
}