using Data.Socket;
using Data.Models;
using Data.Names;
using Data.Commands;
using System.Threading.Tasks;

namespace Data.Controllers
{
    public class PlayerController
    {
        private readonly SocketManager socketManager;

        public PlayerController(SocketManager manager)
        {
            socketManager = manager;
        }

        public async Task<IResponse<bool>> GetProfile()
        {
            return await socketManager.EmitWithAck<IResponse<bool>>(EventNames.PLAYER, PlayerCommands.GetProfile);
        }
    }
}
