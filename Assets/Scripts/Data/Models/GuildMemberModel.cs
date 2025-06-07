using Newtonsoft.Json;

namespace Data.Models
{

    public enum GuildRole
    {
        MEMBER,
        SUB_OWNER,
        OWNER
    }

    public class IGuildMember : Base
    {

        [JsonProperty("role")]
        public GuildRole role;

        [JsonProperty("contributionPoint")]
        public int contributionPoint;

        [JsonProperty("contributionCount")]
        public int contributionCount;

        [JsonProperty("userUUID")]
        public string userUUID;

        [JsonProperty("guildId")]
        public int guildId;
    }
}
