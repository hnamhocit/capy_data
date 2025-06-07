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
        public int hp;
        public int atk;
        public int enemyCount;
        public EnemyType enemyType; // Sử dụng enum
        public int? enemyListId; // Int? -> int?
    }
}
