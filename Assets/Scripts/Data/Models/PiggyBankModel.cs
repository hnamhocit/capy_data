namespace Data.Models
{
    class IPiggyBank : Base
    {
        public int currentLevel;
        public int staminaSpendedInLevel;
        public long? dateTimeUnlockLevel; // BigInt? -> long?
        public long? purchaseTimeLastLevel; // BigInt? -> long?
        public string userUUID;
    }
}
