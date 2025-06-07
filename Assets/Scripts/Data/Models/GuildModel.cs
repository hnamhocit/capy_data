namespace Data.Models
{
    public class IGuild : Base
    {
        public string name;
        public string description;
        public int typeIcon;
        public bool isPublic;
        public int level;
        public int maxMembers;
        public float exp; // Float -> float
        public long coin; // BigInt -> long
        public float maxExp; // Float -> float
    }
}
