using System.Threading.Tasks;
using Data.Commands;
using Data.Models;
using Data.Names;
using Data.Socket;

namespace Data.Controllers
{
    public class TaskController
    {
        public async Task<IResponse<ITask[]>> GetUserTask()
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<ITask[]>>(
                EventNames.TASK,
                TaskCommands.GetUserTasks
            );
        }

        public async Task<IResponse<bool>> ClaimUserTask(int id)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<bool>>(
                EventNames.TASK,
                TaskCommands.ClaimUserTask,
                new { id }
            );
        }
    }
}
