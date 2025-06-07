using System.Threading.Tasks;
using Data.Commands;
using Data.Models;
using Data.Names;
using Data.Socket;

namespace Data.Controllers
{
    public class PiggyBankController
    {
        public async Task<IResponse<bool>> CreatePiggyBank(object data)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<bool>>(
                EventNames.MAIL,
                PiggyBankCommands.CreatePiggyBank,
                data
            );
        }

        public async Task<IResponse<bool>> SetAll(object data)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<bool>>(
                EventNames.MAIL,
                PiggyBankCommands.SetAll,
                data
            );
        }

        public async Task<IResponse<IPiggyBank[]>> GetAll()
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<IPiggyBank[]>>(
                EventNames.MAIL,
                PiggyBankCommands.GetAll
            );
        }
    }
}
