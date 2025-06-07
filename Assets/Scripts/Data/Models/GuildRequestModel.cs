using Newtonsoft.Json;

namespace Data.Models
{
    public class GuildRequestModel
    {
        [JsonProperty("guildId")]
        public int guildId;

        [JsonProperty("userUUID")]
        public string userUUID;
    }
}
