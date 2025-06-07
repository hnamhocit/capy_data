namespace Data.Models
{

    public enum GuildRole
    {
        MEMBER,
        SUB_OWNER,
        OWNER
    }

    public class IGuildMember : Base
    {

        public GuildRole role;
        public int contributionPoint;
        public int contributionCount;

        public string userUUID;
        public int guildId;
    }
}
