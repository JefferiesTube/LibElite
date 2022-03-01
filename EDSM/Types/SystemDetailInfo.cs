using LibElite.Helper;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace LibElite.EDSM.Types
{
    public class SystemDetailInfo
    {
        [J("name")] public string Name { get; set; }
        [J("coords")] public Coords Coords { get; set; }
        [J("information")] public Information Information { get; set; }
        [J("primaryStar")] public PrimaryStar PrimaryStar { get; set; }
    }

    public class Coords
    {
        [J("x")] public double? X { get; set; }
        [J("y")] public double? Y { get; set; }
        [J("z")] public double? Z { get; set; }
    }

    public static class CoordsHelper
    {
        public static Vector3 ToVector(this Coords c)
        {
            if (!c.X.HasValue || !c.Y.HasValue || !c.Z.HasValue)
                return null;
            return new Vector3(c.X.Value, c.Y.Value, c.Z.Value);
        }
    }

    public class Information
    {
        [J("allegiance")] public string Allegiance { get; set; }
        [J("government")] public string Government { get; set; }
        [J("faction")] public string Faction { get; set; }
        [J("factionState")] public string FactionState { get; set; }
        [J("population")] public long? Population { get; set; }
        [J("security")] public string Security { get; set; }
        [J("economy")] public string Economy { get; set; }
    }

    public class PrimaryStar
    {
        [J("type")] public string Type { get; set; }
        [J("name")] public string Name { get; set; }
        [J("isScoopable")] public bool IsScoopable { get; set; }
    }
}