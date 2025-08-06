using ProductService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.Domain.Repostitories
{
    public interface IDiscountRepository
    {
        Task<List<Discount>> GetDiscountsByProductIdAsync(Guid productId);

        Task<Discount?> GetActiveDiscountByProductIdAsync(Guid productId);

        Task<Discount?> AddDiscountAsync(Discount discount);

        Task<Discount?> UpdateDiscountAsync(Discount discount);

        Task DeleteDiscountAsync(Guid discountId);
    }
}
