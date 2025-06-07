using System.Threading.Tasks;
using Data.Commands;
using Data.Models;
using Data.Names;
using Data.Socket;

namespace Data.Controllers
{
    public class BattlePassController
    {
        public async Task<IResponse<IBattlePass[]>> GetUserBattlePasses()
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<IBattlePass[]>>(
                EventNames.BATTLE_PASS,
                BattlePassCommands.GetUserBattlePasses
            );
        }

        public async Task<IResponse<IBattlePass>> GetUserBattlePass(BattlePassType type)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<IBattlePass>>(
                EventNames.BATTLE_PASS,
                BattlePassCommands.GetUserBattlePass,
                new { type }
            );
        }

        public async Task<IResponse<bool>> UpdateBattlePass(object data)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<bool>>(
                EventNames.BATTLE_PASS,
                BattlePassCommands.UpdateUserBattlePass,
                data
            );
        }
    }
}
