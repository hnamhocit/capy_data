using Newtonsoft.Json;

namespace Data.Models
{
    public enum BattlePassType
    {
        BATTLEPASS,
        TALENT,
        DUNGEON,
        TOWER
    }

    public class IBattlePass : Base
    {
        [JsonProperty("name")]
        public string name;

        [JsonProperty("type")]
        public BattlePassType type;

        [JsonProperty("maxLevelUnlocked")]
        public int maxLevelUnlocked;

        [JsonProperty("extraLevelReceived")]
        public int extraLevelReceived;

        [JsonProperty("currentExp")]
        public int currentExp;

        [JsonProperty("currentExtraLevel")]
        public int currentExtraLevel;

        [JsonProperty("currentLevelGetRewards")]
        public int currentLevelGetRewards;

        [JsonProperty("isFirstTimeReceivedActive")]
        public bool isFirstTimeReceivedActive;

        [JsonProperty("isActivate")]
        public bool isActivate;

        [JsonProperty("seasonId")]
        public int? seasonId; // Sử dụng int? để cho phép giá trị null từ JSON

        [JsonProperty("userUUID")]
        public string userUUID;
    }
}
