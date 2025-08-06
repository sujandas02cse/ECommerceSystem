using ProductService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.Domain.Repostitories
{
    public interface IProductImageRepository
    {
        Task<List<ProductImage>> GetProductImagesAsync(Guid productId);

        Task<ProductImage?> GetProductImageByIdAsync(Guid imageId);

        Task<ProductImage?> AddProductImageAsync(ProductImage image);

        Task<ProductImage?> UpdateProductImageAsync(ProductImage image);

        Task RemoveProductImageAsync(Guid imageId);
    }
}
