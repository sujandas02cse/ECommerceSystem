using ProductService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.Domain.Repostitories
{
    public interface ICategoryRepository
    {
        Task<Category?> GetCategoryByIdAsync(Guid categoryId);

        Task<List<Category>> GetAllCategoriesAsync();

        Task<Category?> AddCategoryAsync(Category category);

        Task<Category?> UpdateCategoryAsync(Category category);

        Task<bool> DeleteCategoryAsync(Guid categoryId);
    }
}
