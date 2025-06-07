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
        public string name;
        public BattlePassType type;
        public int maxLevelUnlocked;
        public int extraLevelReceived;
        public int currentExp;
        public int currentExtraLevel;
        public int currentLevelGetRewards;
        public bool isFirstTimeReceivedActive;
        public bool isActivate;

        public int? seasonId;
        public string userUUID;
    }
}
