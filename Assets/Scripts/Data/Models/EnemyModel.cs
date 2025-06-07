using Newtonsoft.Json;

namespace Data.Models
{
    public enum EnemyType
    {
        None,
        Skeleton,
        SkeletonBow,
        SkeletonWitch,
        Slime,
        FireSlime,
        BossWireWolf
    }

    public class IEnemy
    {
        [JsonProperty("hp")]
        public int hp;

        [JsonProperty("atk")]
        public int atk;

        [JsonProperty("count")]
        public int count;

        [JsonProperty("type")]
        public EnemyType type;

        [JsonProperty("enemyListId")]
        public int? enemyListId;
    }
}

