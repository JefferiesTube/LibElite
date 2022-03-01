using Newtonsoft.Json;

namespace LibElite.EDSM.Types
{
    public class NearbySystems
    {
        [JsonProperty("distance")]
        public double Distance { get; set; }

        [JsonProperty("bodyCount")]
        public long? BodyCount { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("coords")]
        public Coords Coords { get; set; }

        protected bool Equals(NearbySystems other)
        {
            return Name == other.Name;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((NearbySystems) obj);
        }

        public override int GetHashCode()
        {
            return Name != null ? Name.GetHashCode() : 0;
        }
    }
}