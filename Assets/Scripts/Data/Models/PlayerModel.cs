using Newtonsoft.Json;

namespace Data.Models
{
    public class InventoryItem
    {
        public int itemId;
        public int quantity;
    }

    public class IUser : Base
    {
        [JsonProperty("UUID")]
        public string UUID;

        [JsonProperty("username")]
        public string username;

        [JsonProperty("avatar")]
        public string avatar;
        // public long gold;
        // public long gem;
        // public long power;
        //
        // public DateTime energyLastUpdate;
        // public int energyValue;
        // public int energyMaxValue;
        // public int Chapter;
        //
        // public int rewardPoint;
        // public int totalExpTalent;
        // public int lvAtkTalent;
        // public int lvDefTalent;
        // public int lvHpTalent;
        //
        // public int towerTicket;
        // public int minerCount;
        // public int currentTowerId;
        // public int currentFloorId;
        // public int mountId;
        // public int[] petSlot;
        // public int currentDungeon;
        // public int rankId;

        // public InventoryItem[] inventory;
    }
}
