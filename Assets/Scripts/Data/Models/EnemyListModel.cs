using Newtonsoft.Json;

namespace Data.Models
{
    public class IEnemyList : Base
    {
        [JsonProperty("dialog")]
        public string dialog;

        [JsonProperty("count")]
        public int count;

        [JsonProperty("enemies")]
        public IEnemy[] enemies;

        [JsonProperty("getWhenDone")]
        public IPlayCurrent[] getWhenDone;
    }
}
