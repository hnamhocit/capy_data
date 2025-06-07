using System.Threading.Tasks;
using Data.Commands;
using Data.Names;
using Data.Socket;

namespace Data.Controllers
{
    public class GuildMemberController
    {
        public async Task<IResponse<bool>> DonateGuild()
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<bool>>(
                EventNames.GUILD_MEMBER,
                GuildMemberCommands.DonateGuild
            );
        }
    }
}
