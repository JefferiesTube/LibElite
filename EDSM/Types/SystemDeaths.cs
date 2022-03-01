using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace LibElite.EDSM.Types
{
    public class SystemDeaths
    {
        [J("id")] public long? Id { get; set; }
        [J("id64")] public long? Id64 { get; set; }
        [J("name")] public string Name { get; set; }
        [J("deaths")] public Deaths Deaths { get; set; }
    }

    public class Deaths
    {
        [J("total")] public long? Total { get; set; }
        [J("week")] public long? Week { get; set; }
        [J("day")] public long? Day { get; set; }
    }
}