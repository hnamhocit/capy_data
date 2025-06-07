namespace Data.Models
{
    public class IEnemyList : Base
    {
        public string dialog;
        public int enemyCount;
        public IEnemy[] enemies; // Json -> List<Enemy>
        public IPlayCurrent[] getWhenDone; // Json -> List<PlayCurrent>
    }
}
