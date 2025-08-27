using ProductService.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.Application.Interfaces
{
    public interface IInventoryService
    {
        Task<bool> IsStockAvailableAsync(Guid productId, int quantity);

        Task UpdateStockAsync(InventoryUpdateDTO inventoryUpdateDto);

        Task DecreaseStockAsync(Guid productId, int quantity);

        Task IncreaseStockAsync(Guid productId, int quantity);
    }
}
