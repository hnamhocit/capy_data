using System.Threading.Tasks;
using Data.Commands;
using Data.Models;
using Data.Names;
using Data.Socket;

namespace Data.Controllers
{
    public class GuildConstroller
    {
        public async Task<IResponse<IGuild[]>> GetGuilds()
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<IGuild[]>>(
                EventNames.GUILD,
                GuildCommands.GetGuilds
            );
        }

        public async Task<IResponse<IGuild>> GetGuild(int id)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<IGuild>>(
                EventNames.GUILD,
                GuildCommands.GetGuild,
                new { id }
            );
        }

        public async Task<IResponse<IGuild>> GetCurrentGuild()
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<IGuild>>(
                EventNames.GUILD,
                GuildCommands.GetCurrentGuild
            );
        }

        public async Task<IResponse<int>> CreateGuild(object data)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<int>>(
                EventNames.GUILD,
                GuildCommands.CreateGuild,
                data
            );
        }

        public async Task<IResponse<bool>> JoinGuild(int id)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<bool>>(
                EventNames.GUILD,
                GuildCommands.JoinGuild,
                new { id }
            );
        }

        public async Task<IResponse<bool>> AcceptRequest(string UUID)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<bool>>(
                EventNames.GUILD,
                GuildCommands.AcceptRequest,
                new { UUID }
            );
        }

        public async Task<IResponse<bool>> RejectRequest(string UUID)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<bool>>(
                EventNames.GUILD,
                GuildCommands.RejectRequest,
                new { UUID }
            );
        }

        public async Task<IResponse<bool>> KickMember(string UUID)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<bool>>(
                EventNames.GUILD,
                GuildCommands.KickMember,
                new { UUID }
            );
        }

        public async Task<IResponse<bool>> LeaveGuild()
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<bool>>(
                EventNames.GUILD,
                GuildCommands.LeaveGuild
            );
        }

        public async Task<IResponse<bool>> ChangePrivacy()
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<bool>>(
                EventNames.GUILD,
                GuildCommands.ChangePrivacy
            );
        }

        public async Task<IResponse<bool>> UpdateGuild(object data)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<bool>>(
                EventNames.GUILD,
                GuildCommands.UpdateGuild,
                data
            );
        }
    }
}
