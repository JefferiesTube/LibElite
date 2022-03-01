using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Startup
{
    [EventType("LoadGame")]
    public class LoadGame : EventBase
    {
        public string Commander { get; set; }
        public string FID { get; set; }
        public bool Horizons { get; set; }
        public bool Odyssey { get; set; }
        public string Ship { get; set; }
        public string Language { get; set; }
        public string GameVersion { get; set; }
        public string Build { get; set; }
        public string Ship_Localised { get; set; }
        public long ShipID { get; set; }
        public bool StartLanded { get; set; }
        public bool StartDead { get; set; }
        public GameMode GameMode { get; set; }
        public string Group { get; set; }
        public long Credits { get; set; }
        public long Loan { get; set; }
        public string ShipName { get; set; }
        public string ShipIdent { get; set; }
        public double FuelLevel { get; set; }
        public double FuelCapacity { get; set; }
    }
}