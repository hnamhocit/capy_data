using Data.Commands;
using Data.Names;
using Data.Socket;
using System.Threading.Tasks;
using Data.Models;

namespace Data.Controllers
{
    class BattlePassController
    {
        private SocketManager socketManager;

        async Task<IBattlePass[]> GetBattlePasses()
        {
            return await socketManager.EmitWithAck<IBattlePass[]>(EventNames.BATTLE_PASS, BattlePassCommands.GetUserBattlePasses);
        }

        async Task<IBattlePass> GetBattlePass(int id)
        {
            return await socketManager.EmitWithAck<IBattlePass>(EventNames.BATTLE_PASS, BattlePassCommands.GetUserBattlePass, new { id });
        }
    }
}
