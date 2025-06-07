using Newtonsoft.Json;

namespace Data.Models
{
    public class IQuestCompleted
    {
        [JsonProperty("questId")]
        public int questId;

        [JsonProperty("userUUID")]
        public string userUUID;
    }
}
