using Newtonsoft.Json;

namespace Data.Models
{
    public class IEquipment : Base
    {
        [JsonProperty("itemId")]
        public int itemId;

        [JsonProperty("isEquip")]
        public bool isEquip;

        [JsonProperty("level")]
        public int level;

        [JsonProperty("userUUID")]
        public string userUUID;
    }
}
