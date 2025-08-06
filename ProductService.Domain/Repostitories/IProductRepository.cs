using ProductService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.Domain.Repostitories
{
    public interface IProductRepository
    {
        Task<Product?> GetByIdAsync(Guid productId);

        Task<List<Product>> GetAllAsync(int pageNumber = 1, int pageSize = 10);

        Task<List<Product>> SearchAsync(string? searchTerm, Guid? categoryId, decimal? minPrice, decimal? maxPrice, int pageNumber = 1, int pageSize = 10);

        Task<Product?> AddAsync(Product product);

        Task<Product?> UpdateAsync(Product product);

        Task DeleteAsync(Guid productId);
    }
}
