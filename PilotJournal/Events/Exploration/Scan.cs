using System.Collections.Generic;
using LibElite.PilotJournal.Converter;
using Newtonsoft.Json;

namespace LibElite.PilotJournal.Events.Exploration
{
    [EventType("Scan")]
    public class Scan : EventBase
    {
        public string ScanType { get; set; }
        public string Bodyname { get; set; }
        public long BodyID { get; set; }
        public double DistanceFromArrivalLS { get; set; }
        public string StarType { get; set; }
        public long StellarMass { get; set; }
        public double Radius { get; set; }
        public double AbsoluteMagnitude { get; set; }
        public long RotationPeriod { get; set; }
        public double SurfaceTemperature { get; set; }
        public string Luminosity { get; set; }
        public double Age_MY { get; set; }
        public BodyRing[] Rings { get; set; }
        public KeyValuePair<string, int>[] Parents { get; set; }
        public bool TidalLock { get; set; }
        public string TerraformState { get; set; }
        public double MassEM { get; set; }
        public string PlanetClass { get; set; }
        public string Atmosphere { get; set; }
        public string AtmosphereType { get; set; }
        public MaterialComposition[] AtmosphereComposition { get; set; }
        public string Volcanism { get; set; }
        public double SurfaceGravity { get; set; }
        public double SurfacePressure { get; set; }
        public bool Landable { get; set; }
        [JsonConverter(typeof(ScanMaterialsConverter))] public MaterialComposition[] Materials { get; set; }
        public BodyComposition Composition { get; set; }
        public ReserveLevel ReserveLevel { get; set; }
        public double AxialTilt { get; set; }
        public double SemiMajorAxis { get; set; }
        public double Eccentricity { get; set; }
        public double OrbitalInclination { get; set; }
        public double Periapsis { get; set; }
        public double OrbitalPeriod { get; set; }
        public int Subclass { get; set; }
        public bool WasDiscovered { get; set; }
        public bool WasMapped { get; set; }
        public string StarSystem { get; set; }
        public long SystemAddress { get; set; }
    }

    public class MaterialComposition
    {
        public string Name { get; set; }
        public string Name_Localised { get; set; }
        public double Percent { get; set; }
    }

    public class BodyComposition
    {
        public double Ice { get; set; }
        public double Rock { get; set; }
        public double Metal { get; set; }
    }

    public class BodyRing
    {
        public string Name;
        public string RingClass;
        public double MassMT;
        public double InnerRad;
        public double OuterRad;
    }
}