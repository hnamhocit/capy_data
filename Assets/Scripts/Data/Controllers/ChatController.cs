using System.Threading.Tasks;
using Data.Commands;
using Data.Models;
using Data.Names;
using Data.Socket;

namespace Data.Controllers
{
    public class ChatController
    {
        public async Task<IResponse<bool>> JoinChat(string channel)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<bool>>(
                EventNames.CHAT,
                ChatCommands.JoinChat,
                new { channel }
            );
        }

        public async Task<IResponse<IMessage>> SendChat(object data)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<IMessage>>(
                EventNames.CHAT,
                ChatCommands.SendChat,
                data
            );
        }
    }
}
