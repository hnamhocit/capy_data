using System.Threading.Tasks;
using Data.Commands;
using Data.Names;
using Data.Socket;

namespace Data.Controllers
{
    public class DebugController
    {
        public async Task<IResponse<bool>> Set(object data)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<bool>>(
                EventNames.DEBUG,
                DebugCommands.Set,
                data
            );
        }
    }
}
