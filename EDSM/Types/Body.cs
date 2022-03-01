using System;
using System.Collections.Generic;
using J = Newtonsoft.Json.JsonPropertyAttribute;
using N = Newtonsoft.Json.NullValueHandling;

namespace LibElite.EDSM.Types
{
    public class SystemBodies
    {
        [J("id")] public long Id { get; set; }
        [J("id64")] public long Id64 { get; set; }
        [J("name")] public string Name { get; set; }
        [J("url")] public Uri Url { get; set; }
        [J("bodyCount")] public long BodyCount { get; set; }
        [J("bodies")] public Body[] Bodies { get; set; }
    }

    public class Body
    {
        [J("id")] public long? Id { get; set; }
        [J("id64")] public long? Id64 { get; set; }
        [J("bodyId")] public long? BodyId { get; set; }
        [J("name")] public string Name { get; set; }
        [J("discovery")] public Discovery Discovery { get; set; }
        [J("type")] public string Type { get; set; }
        [J("subType")] public string SubType { get; set; }
        [J("parents")] public Parent[] Parents { get; set; }
        [J("distanceToArrival")] public long DistanceToArrival { get; set; }
        [J("isMainStar", NullValueHandling = N.Ignore)] public bool? IsMainStar { get; set; }
        [J("isScoopable", NullValueHandling = N.Ignore)] public bool? IsScoopable { get; set; }
        [J("age", NullValueHandling = N.Ignore)] public long? Age { get; set; }
        [J("spectralClass", NullValueHandling = N.Ignore)] public string SpectralClass { get; set; }
        [J("luminosity", NullValueHandling = N.Ignore)] public string Luminosity { get; set; }
        [J("absoluteMagnitude", NullValueHandling = N.Ignore)] public double? AbsoluteMagnitude { get; set; }
        [J("solarMasses", NullValueHandling = N.Ignore)] public long? SolarMasses { get; set; }
        [J("solarRadius", NullValueHandling = N.Ignore)] public double? SolarRadius { get; set; }
        [J("surfaceTemperature")] public long SurfaceTemperature { get; set; }
        [J("orbitalPeriod")] public double? OrbitalPeriod { get; set; }
        [J("semiMajorAxis")] public double? SemiMajorAxis { get; set; }
        [J("orbitalEccentricity")] public double? OrbitalEccentricity { get; set; }
        [J("orbitalInclination")] public double? OrbitalInclination { get; set; }
        [J("argOfPeriapsis")] public double? ArgOfPeriapsis { get; set; }
        [J("rotationalPeriod")] public double RotationalPeriod { get; set; }
        [J("rotationalPeriodTidallyLocked")] public bool RotationalPeriodTidallyLocked { get; set; }
        [J("axialTilt")] public double? AxialTilt { get; set; }
        [J("belts", NullValueHandling = N.Ignore)] public Belt[] Belts { get; set; }
        [J("updateTime")] public DateTimeOffset UpdateTime { get; set; }
        [J("isLandable", NullValueHandling = N.Ignore)] public bool? IsLandable { get; set; }
        [J("gravity", NullValueHandling = N.Ignore)] public double? Gravity { get; set; }
        [J("earthMasses", NullValueHandling = N.Ignore)] public double? EarthMasses { get; set; }
        [J("radius", NullValueHandling = N.Ignore)] public double? Radius { get; set; }
        [J("surfacePressure")] public double? SurfacePressure { get; set; }
        [J("volcanismType", NullValueHandling = N.Ignore)] public string VolcanismType { get; set; }
        [J("atmosphereType", NullValueHandling = N.Ignore)] public string AtmosphereType { get; set; }
        [J("atmosphereComposition")] public AtmosphereComposition AtmosphereComposition { get; set; }
        [J("solidComposition")] public SolidComposition SolidComposition { get; set; }
        [J("terraformingState")] public string TerraformingState { get; set; }
        [J("materials", NullValueHandling = N.Ignore)] public Dictionary<string, double> Materials { get; set; }
        [J("rings", NullValueHandling = N.Ignore)] public Belt[] Rings { get; set; }
        [J("reserveLevel", NullValueHandling = N.Ignore)] public string ReserveLevel { get; set; }
    }

    public class AtmosphereComposition
    {
        [J("Carbon dioxide", NullValueHandling = N.Ignore)] public double? CarbonDioxide { get; set; }
        [J("Nitrogen", NullValueHandling = N.Ignore)] public double? Nitrogen { get; set; }
        [J("Oxygen", NullValueHandling = N.Ignore)] public double? Oxygen { get; set; }
        [J("Argon", NullValueHandling = N.Ignore)] public double? Argon { get; set; }
        [J("Water", NullValueHandling = N.Ignore)] public double? Water { get; set; }
        [J("Hydrogen", NullValueHandling = N.Ignore)] public double? Hydrogen { get; set; }
        [J("Helium", NullValueHandling = N.Ignore)] public double? Helium { get; set; }
        [J("Sulphur dioxide", NullValueHandling = N.Ignore)] public long? SulphurDioxide { get; set; }
        [J("Silicates", NullValueHandling = N.Ignore)] public long? Silicates { get; set; }
        [J("Methane", NullValueHandling = N.Ignore)] public double? Methane { get; set; }
    }

    public class Belt
    {
        [J("name")] public string Name { get; set; }
        [J("type")] public string Type { get; set; }
        [J("mass")] public long Mass { get; set; }
        [J("innerRadius")] public long InnerRadius { get; set; }
        [J("outerRadius")] public long OuterRadius { get; set; }
    }

    public class Discovery
    {
        [J("commander")] public string Commander { get; set; }
        [J("date")] public DateTimeOffset Date { get; set; }
    }

    public class Parent
    {
        [J("Star", NullValueHandling = N.Ignore)] public long? Star { get; set; }
        [J("Planet", NullValueHandling = N.Ignore)] public long? Planet { get; set; }
        [J("Null", NullValueHandling = N.Ignore)] public long? Null { get; set; }
    }

    public class SolidComposition
    {
        [J("Metal")] public double Metal { get; set; }
        [J("Rock")] public double Rock { get; set; }
        [J("Ice")] public long Ice { get; set; }
    }
}