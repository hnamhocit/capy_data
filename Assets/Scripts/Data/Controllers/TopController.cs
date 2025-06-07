using System.Threading.Tasks;
using Data.Commands;
using Data.Models;
using Data.Names;
using Data.Socket;

namespace Data.Controllers
{
    public class TopController
    {
        public async Task<IResponse<IUser[]>> GetTopChapter()
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<IUser[]>>(
                EventNames.TOP,
                TopCommands.GetTopChapter
            );
        }

        public async Task<IResponse<IGuild[]>> GetTopGuild()
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<IGuild[]>>(
                EventNames.TOP,
                TopCommands.GetTopGuild
            );
        }

        public async Task<IResponse<IUser[]>> GetTopTower()
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<IUser[]>>(
                EventNames.TOP,
                TopCommands.GetTopTower
            );
        }

        public async Task<IResponse<IUser[]>> GetTopDungeon()
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<IUser[]>>(
                EventNames.TOP,
                TopCommands.GetTopDungeon
            );
        }
    }
}
