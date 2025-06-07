using System.Threading.Tasks;
using Data.Commands;
using Data.Models;
using Data.Names;
using Data.Socket;

namespace Data.Controllers
{
    public class PlayerController
    {
        public async Task<IResponse<IUser>> GetProfile()
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<IUser>>(
                EventNames.PLAYER,
                PlayerCommands.GetProfile
            );
        }

        public async Task<IResponse<IUser>> GetUser(string UUID)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<IUser>>(
                EventNames.PLAYER,
                PlayerCommands.GetUser,
                new { UUID }
            );
        }

        public async Task<IResponse<int>> DecreaseEnergy()
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<int>>(
                EventNames.PLAYER,
                PlayerCommands.DescreaseEnergy
            );
        }

        public async Task<IResponse<int>> IncreaseEnergy()
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<int>>(
                EventNames.PLAYER,
                PlayerCommands.IncreaseEnergy
            );
        }

        public async Task<IResponse<bool>> Rename(string username)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<bool>>(
                EventNames.PLAYER,
                PlayerCommands.Rename,
                new { username }
            );
        }

        public async Task<IResponse<bool>> SetPower(long power)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<bool>>(
                EventNames.PLAYER,
                PlayerCommands.SetPower,
                new { power }
            );
        }

        public async Task<IResponse<bool>> SetRank(string rank)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<bool>>(
                EventNames.PLAYER,
                PlayerCommands.SetRank,
                new { rank }
            );
        }

        public async Task<IResponse<InventoryItem[]>> GetInventory()
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<InventoryItem[]>>(
                EventNames.PLAYER,
                PlayerCommands.GetInventory
            );
        }

        public async Task<IResponse<IEquipment[]>> GetUserEquipments()
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<IEquipment[]>>(
                EventNames.PLAYER,
                PlayerCommands.GetUserEquipment
            );
        }

        public async Task<IResponse<InventoryItem[]>> SaveInventory(InventoryItem[] items)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<InventoryItem[]>>(
                EventNames.PLAYER,
                PlayerCommands.SaveInventory,
                items
            );
        }
    }
}
