using System.Threading.Tasks;
using Data.Commands;
using Data.Models;
using Data.Names;
using Data.Socket;

namespace Data.Controllers
{
    public class EventController
    {
        public async Task<IResponse<IEvent[]>> GetEvents()
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<IEvent[]>>(
                EventNames.EVENT,
                EventCommands.GetEvents,
                null
            );
        }

        public async Task<IResponse<IEvent>> GetEvent(int id)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<IEvent>>(
                EventNames.EVENT,
                EventCommands.GetEvent,
                new { id }
            );
        }

        public async Task<IResponse<IEvent>> CreateEvent(object data)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<IEvent>>(
                EventNames.EVENT,
                EventCommands.CreateEvent,
                data
            );
        }

        public async Task<IResponse<IEvent>> UpdateEvent(object data)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<IEvent>>(
                EventNames.EVENT,
                EventCommands.UpdateEvent,
                data
            );
        }
    }
}
