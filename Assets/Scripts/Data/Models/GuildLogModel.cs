namespace Data.Models
{
    public class IGuildLog : Base
    {
        public int guildId;
        public long timestamp; // BigInt -> long
        public string message;
    }
}
