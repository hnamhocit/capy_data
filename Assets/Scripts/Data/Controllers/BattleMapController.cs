using Data.Socket;
using Data.Commands;
using Data.Names;
using Data.Models;
using System.Threading.Tasks;

namespace Data.Controllers
{
    class BattleMapController
    {
        private SocketManager socketManager;

        public BattleMapController(SocketManager manager)
        {
            socketManager = manager;
        }

        public async Task<IResponse<dynamic[]>> GetBattleMaps()
        {
            return await socketManager.EmitWithAck<IResponse<dynamic[]>>(EventNames.BATTLE_MAP, BattleMapCommands.GetBattleMaps);
        }

        public async Task<IResponse<dynamic>> GetBattleMap(int id)
        {
            return await socketManager.EmitWithAck<IResponse<dynamic>>(EventNames.BATTLE_MAP, BattleMapCommands.GetBattleMap, new { id });
        }
    }
}
