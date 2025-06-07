using Newtonsoft.Json;

namespace Data.Models
{
    public class IGuildLog : Base
    {
        [JsonProperty("guildId")]
        public int guildId;

        [JsonProperty("timestamp")] // BigInt thường được map sang long trong C#
        public long timestamp;

        [JsonProperty("message")]
        public string message;
    }
}
