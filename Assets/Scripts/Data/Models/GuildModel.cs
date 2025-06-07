using Newtonsoft.Json;

namespace Data.Models
{
    public class IGuild : Base
    {
        [JsonProperty("name")]
        public string name;

        [JsonProperty("description")]
        public string description;

        [JsonProperty("typeIcon")]
        public int typeIcon;

        [JsonProperty("isPublic")]
        public bool isPublic;

        [JsonProperty("level")]
        public int level;

        [JsonProperty("maxMembers")]
        public int maxMembers;

        [JsonProperty("exp")] // Float map sang float trong C#
        public float exp;

        [JsonProperty("coin")] // BigInt map sang long trong C#
        public long coin;

        [JsonProperty("maxExp")] // Float map sang float trong C#
        public float maxExp;
    }
}
