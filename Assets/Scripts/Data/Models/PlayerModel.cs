using Newtonsoft.Json;
using System;

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

        [JsonProperty("gold")]
        public long gold;

        [JsonProperty("gem")]
        public long gem;

        [JsonProperty("power")]
        public long power;

        [JsonProperty("energyLastUpdate")]
        public DateTime energyLastUpdate;

        [JsonProperty("energyValue")]
        public int energyValue;

        [JsonProperty("energyMaxValue")]
        public int energyMaxValue;

        [JsonProperty("chapter")]
        public int chapter;

        [JsonProperty("rewardPoint")]
        public int rewardPoint;

        [JsonProperty("totalExpTalent")]
        public int totalExpTalent;

        [JsonProperty("lvAtkTalent")]
        public int lvAtkTalent;

        [JsonProperty("lvDefTalent")]
        public int lvDefTalent;

        [JsonProperty("lvHpTalent")]
        public int lvHpTalent;

        [JsonProperty("towerTicket")]
        public int towerTicket;

        [JsonProperty("minerCount")]
        public int minerCount;

        [JsonProperty("currentTowerId")]
        public int currentTowerId;

        [JsonProperty("currentFloorId")]
        public int currentFloorId;

        [JsonProperty("mountId")]
        public int mountId;

        [JsonProperty("petSlot")]
        public int[] petSlot; // Mảng số nguyên

        [JsonProperty("currentDungeon")]
        public int currentDungeon;

        [JsonProperty("rankId")]
        public int rankId;

        [JsonProperty("inventory")]
        public InventoryItem[] inventory; // Mảng các đối tượng InventoryItem
    }



































}
