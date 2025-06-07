using System.Threading.Tasks;
using Data.Commands;
using Data.Models;
using Data.Names;
using Data.Socket;

namespace Data.Controllers
{
    public class BattleMapController
    {
        public async Task<IResponse<IBattleMap[]>> GetBattleMaps()
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<IBattleMap[]>>(
                EventNames.BATTLE_MAP,
                BattleMapCommands.GetBattleMaps
            );
        }

        public async Task<IResponse<IBattleMap>> GetBattleMap(int id)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<IBattleMap>>(
                EventNames.BATTLE_MAP,
                BattleMapCommands.GetBattleMap,
                new { id }
            );
        }
    }
}
