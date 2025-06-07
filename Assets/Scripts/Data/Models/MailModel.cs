namespace Data.Models
{
    public class IMail : Base
    {
        public bool isClaimed;
        public string title;
        public string content;
        public string sender;
        public InventoryItem[] gifts;
        public string userUUID;
    }
}
