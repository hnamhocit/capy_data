using Newtonsoft.Json;

namespace Data.Models
{
    public class IPlayCurrent : Base
    {
        [JsonProperty("type")]
        public int type;

        [JsonProperty("typeAdd")]
        public int typeAdd;

        [JsonProperty("valueAdd")]
        public float valueAdd; // Map từ float

        [JsonProperty("enemyListId")]
        public int enemyListId;
    }
}
