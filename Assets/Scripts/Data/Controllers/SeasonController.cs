using System.Threading.Tasks;
using Data.Commands;
using Data.Models;
using Data.Names;
using Data.Socket;

namespace Data.Controllers
{
    public class SeasonController
    {
        public async Task<IResponse<ISeason>> GetSeason(int id)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<ISeason>>(
                EventNames.SEASON,
                SeasonCommands.GetSeason,
                new { id }
            );
        }

        public async Task<IResponse<bool>> UpdateCurrentSeason(object data)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<bool>>(
                EventNames.SEASON,
                SeasonCommands.UpdateCurrentSeason,
                data
            );
        }

        public async Task<IResponse<bool>> UpdateSeason(object data)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<bool>>(
                EventNames.SEASON,
                SeasonCommands.UpdateSeason,
                data
            );
        }
    }
}
