using Newtonsoft.Json;

namespace Data.Models
{
    public class ITask : Base
    {
        [JsonProperty("rewardPoint")]
        public int rewardPoint;

        [JsonProperty("name")]
        public string name;

        [JsonProperty("isComplete")]
        public bool isComplete;

        [JsonProperty("userUUID")]
        public string userUUID;
    }
}
