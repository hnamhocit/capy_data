using System.Threading.Tasks;
using Data.Commands;
using Data.Names;
using Data.Socket;

namespace Data.Controllers
{
    public class TalentController
    {
        public async Task<IResponse<dynamic>> IncreaseTalentLevel(string name)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<dynamic>>(
                EventNames.TALENT,
                TalentCommands.IncreaseTalentLevel,
                new { name }
            );
        }
    }
}
