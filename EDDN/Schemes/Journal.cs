using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LibElite.EDDN.Schemes
{
    public class Journal
    {
        [JsonProperty("header")]
        public MessageHeader Header;

        [JsonProperty("message")]
        public JournalMessage Message;
    }

    public enum JournalMessageEvent { Docked, FSDJump, Scan, Location, SAASignalsFound }

    public class JournalMessage
    {
        [JsonProperty("timestamp")]
        public DateTime Timestamp;
        [JsonProperty("event")]
        public JournalMessageEvent Event;
        public string StarSystem;
        public double[] StarPos;
        public long SystemAddress;

        // Docked at station
        public string StationType;
        public string[] StationServices;
        public string StationName;
        public string StationGovernment;
        public JournalStationEconomy[] StationEconomies;
        public JournalStationFaction StationFaction;
        public double DistFromStarLS;

        // Scanned bodies
        public int BodyID;
        public string BodyName;
        public double DistanceFromArrivalLS;
        public BodyParent[] Parents;
        public string ScanType;
        public bool WasDiscovered;
        public bool WasMapped;
        public string Atmosphere;
        public string AtmosphereType;
        public double AxialTilt;
        public BodyComposition Composition;
        public double Eccentricity;
        public bool Landable;
        public double MassEM;
        public MaterialEntry[] Materials;
        public double OrbitalInclination;
        public double OrbitalPeriod;
        public double Periapsis;
        public string PlanetClass;
        public double Radius;
        public double RotationPeriod;
        public double SemiMajorAxis;
        public double SurfaceGravity;
        public double SurfacePressure;
        public double SurfaceTemperature;
        public string TerraformState;
        public bool TidalLock;
        public string Volcanism;
        public AtmosphereComposition[] AtmosphereComposition;

        // FSD Jump additional infos
        public string SystemAllegiance;
        public string SystemEconomy;
        public string SystemGovernment;
        public string SystemSecondEconomy;
        public string SystemSecurity;
        public long Population;
        public string Body;
        public string BodyType;
    }

    public class JournalStationEconomy
    {
        public string Name;
        public double Proportion;
    }

    public class JournalStationFaction
    {
        public string FactionState;
        public string Name;

        public static implicit operator JournalStationFaction(string s) => new JournalStationFaction() { FactionState = "Unknown", Name = s};
    }

    public class BodyParent
    {
        [JsonProperty("Ring", NullValueHandling = NullValueHandling.Ignore)]
        public long? Ring { get; set; }

        [JsonProperty("Star", NullValueHandling = NullValueHandling.Ignore)]
        public long? Star { get; set; }

        [JsonProperty("Null", NullValueHandling = NullValueHandling.Ignore)]
        public long? Null { get; set; }
    }

    public class BodyComposition
    {
        public double Ice;
        public double Metal;
        public double Rock;
    }

    public class MaterialEntry
    {
        public string Name;
        public double Percent;
    }

    public class AtmosphereComposition
    {
        public string Name;
        public double Percent;
    }
}
