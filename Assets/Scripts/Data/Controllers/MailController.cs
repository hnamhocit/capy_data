using System.Threading.Tasks;
using Data.Commands;
using Data.Models;
using Data.Names;
using Data.Socket;

namespace Data.Controllers
{
    public class MailController
    {
        public async Task<IResponse<IMail>> SendMail(object data)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<IMail>>(
                EventNames.MAIL,
                MailCommands.SendMail,
                data
            );
        }

        public async Task<IResponse<bool>> DeleteMail(int id)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<bool>>(
                EventNames.MAIL,
                MailCommands.DeleteMail,
                new { id }
            );
        }

        public async Task<IResponse<bool>> ClaimMail(int id)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<bool>>(
                EventNames.MAIL,
                MailCommands.ClaimMail,
                new { id }
            );
        }
    }
}
