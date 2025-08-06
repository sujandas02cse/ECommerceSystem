using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.Domain.Repostitories
{
    public interface IInventoryRepository
    {
        Task<bool> IsStockAvailableAsync(Guid productId, int quantity);

        Task UpdateStockAsync(Guid productId, int stockQuantity);

        Task IncreaseDecsreaseStockAsync(Guid productId, int quantityChange);
    }
}
