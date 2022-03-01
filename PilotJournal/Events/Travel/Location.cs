using LibElite.PilotJournal.Converter;
using LibElite.PilotJournal.Events.BaseClasses;

namespace LibElite.PilotJournal.Events.Travel
{
    [EventType("Location")]
    public class Location : JumpEvent
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string[] Powers { get; set; }
        public string PowerplayState { get; set; }
        public SystemFaction SystemFaction { get; set; }
        public string StationAllegiance { get; set; }
        public string FactionState { get; set; }
        public double DistFromStarLS { get; set; }
        public bool Wanted { get; set; }
        public bool Taxi { get; set; }
        public bool Multicrew { get; set; }
        public bool OnFoot { get; set; }
        public bool InSRV { get; set; }
        public LocalFaction[] Factions { get; set; }
        public Conflict[] Conflicts { get; set; }
    }

    public class StationEconomy
    {
        public string Name { get; set; }
        public string Name_Localised { get; set; }
        public double Proportion { get; set; }
    }

    public class SystemFaction
    {
        public string Name { get; set; }
        public string FactionState { get; set; }

        public static implicit operator SystemFaction(string input)
        {
            return new SystemFaction() { Name = input, FactionState = "" };
        }
    }

    public class FactionState
    {
        public string State { get; set; }
        public double Trend { get; set; }
    }

    public class StationFaction
    {
        public string Name { get; set; }
        public string FactionState { get; set; }

        public static implicit operator StationFaction(string s) => new StationFaction() { FactionState = "Unknown", Name = s };
    }
}