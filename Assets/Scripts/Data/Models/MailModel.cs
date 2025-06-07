using Newtonsoft.Json;

namespace Data.Models
{
    public class IMail : Base
    {
        [JsonProperty("isClaimed")]
        public bool isClaimed;

        [JsonProperty("title")]
        public string title;

        [JsonProperty("content")]
        public string content;

        [JsonProperty("sender")]
        public string sender;

        [JsonProperty("gifts")]
        public InventoryItem[] gifts;

        [JsonProperty("userUUID")]
        public string userUUID;
    }
}
