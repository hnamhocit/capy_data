using System.Threading.Tasks;
using Data.Commands;
using Data.Models;
using Data.Names;
using Data.Socket;

namespace Data.Controllers
{
    public class EquipmentController
    {
        public async Task<IResponse<bool>> ToggleIsEquip(int id)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<bool>>(
                EventNames.EQUIPMENT,
                EquipmentCommands.ToggleIsEquip,
                new { id }
            );
        }

        public async Task<IResponse<bool>> LevelUp(int id)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<bool>>(
                EventNames.EQUIPMENT,
                EquipmentCommands.LevelUp,
                new { id }
            );
        }

        public async Task<IResponse<IEquipment>> GetEquipment(int id)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<IEquipment>>(
                EventNames.EQUIPMENT,
                EquipmentCommands.GetEquipment,
                new { id }
            );
        }

        public async Task<IResponse<IEquipment[]>> GetEquipments()
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<IEquipment[]>>(
                EventNames.EQUIPMENT,
                EquipmentCommands.GetEquipments,
                null
            );
        }

        public async Task<IResponse<bool>> SaveEquipment(int id)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<bool>>(
                EventNames.EQUIPMENT,
                EquipmentCommands.SaveEquipment,
                id
            );
        }

        public async Task<IResponse<bool>> SaveEquipments(int[] ids)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<bool>>(
                EventNames.EQUIPMENT,
                EquipmentCommands.SaveEquipments,
                ids
            );
        }
    }
}
