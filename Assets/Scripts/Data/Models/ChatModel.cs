using Newtonsoft.Json;

namespace Data.Models
{
    public class ISender
    {
        [JsonProperty("uuid")]
        public string uuid;

        [JsonProperty("avatar")]
        public string avatar;

        [JsonProperty("username")]
        public string username;
    }

    public class IMessage
    {
        [JsonProperty("channel")]
        public string channel;

        [JsonProperty("msg")]
        public string msg;

        [JsonProperty("sender")]
        public ISender sender;

        [JsonProperty("createdAt")]
        public long createdAt;
    }
}
