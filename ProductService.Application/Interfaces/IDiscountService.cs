using ProductService.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.Application.Interfaces
{
    public interface IDiscountService
    {
        Task<List<DiscountDTO>> GetByProductIdAsync(Guid productId); //Active and Inactive 

        Task<DiscountDTO?> GetActiveDiscountByProductIdAsync(Guid productId);

        Task<DiscountDTO?> AddAsync(DiscountCreateDTO createDto);

        Task<DiscountDTO?> UpdateAsync(DiscountUpdateDTO updateDto);

        Task DeleteAsync(Guid discountId);
    }
}
