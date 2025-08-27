using ProductService.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.Application.Interfaces
{
    public interface IProductImageService
    {
        Task<List<ProductImageDTO>> GetByProductIdAsync(Guid productId);

        Task<ProductImageDTO?> GetByIdAsync(Guid imageId);

        Task<ProductImageDTO?> AddAsync(ProductImageCreateDTO createDto);

        Task<ProductImageDTO?> UpdateAsync(ProductImageUpdateDTO updateDto);

        Task DeleteAsync(Guid imageId);
    }
}
