using Newtonsoft.Json;

namespace Data.Models
{
    public class IBattleMap : Base
    {
        [JsonProperty("maxStage")]
        public int maxStage;

        [JsonProperty("battleStates")]
        public int[] battleStates;

        [JsonProperty("eventStages")]
        public int[] eventStages;

        [JsonProperty("bossStages")]
        public int[] bossStages;

        [JsonProperty("bigBossStages")]
        public int[] bigBossStages;

        [JsonProperty("enemyList")]
        public IEnemyList[] enemyList;

        [JsonProperty("bigBossList")]
        public IEnemyList[] bigBossList;

        [JsonProperty("bossList")]
        public IEnemyList[] bossList;
    }
}
