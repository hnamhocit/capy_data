using Newtonsoft.Json;

namespace Data.Models
{
    public class IPiggyBank : Base
    {
        [JsonProperty("currentLevel")]
        public int currentLevel;

        [JsonProperty("staminaSpendedInLevel")]
        public int staminaSpendedInLevel;

        [JsonProperty("dateTimeUnlockLevel")] // BigInt? map sang long?
        public long? dateTimeUnlockLevel;

        [JsonProperty("purchaseTimeLastLevel")] // BigInt? map sang long?
        public long? purchaseTimeLastLevel;

        [JsonProperty("userUUID")]
        public string userUUID;
    }
}
