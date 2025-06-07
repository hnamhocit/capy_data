using System.Threading.Tasks;
using Data.Commands;
using Data.Models;
using Data.Names;
using Data.Socket;

namespace Data.Controllers
{
    public class ShopController
    {
        public async Task<IResponse<InventoryItem[]>> OpenEquipmentChess(object data)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<InventoryItem[]>>(
                EventNames.SHOP,
                ShopCommands.OpenEquipmentChess,
                data
            );
        }

        public async Task<IResponse<InventoryItem[]>> OpenLegendaryMysteriousChest(int quantity)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<InventoryItem[]>>(
                EventNames.SHOP,
                ShopCommands.OpenLegendaryMysteriousChest,
                new { quantity }
            );
        }

        public async Task<IResponse<InventoryItem[]>> OpenLimitedSecretChest(int quantity)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<InventoryItem[]>>(
                EventNames.SHOP,
                ShopCommands.OpenLimitedSecretChest,
                new { quantity }
            );
        }

        public async Task<IResponse<InventoryItem[]>> OpenPackage(int id)
        {
            return await SocketManager.Instance.EmitWithAck<IResponse<InventoryItem[]>>(
                EventNames.SHOP,
                ShopCommands.OpenPackage,
                new { id }
            );
        }
    }
}
