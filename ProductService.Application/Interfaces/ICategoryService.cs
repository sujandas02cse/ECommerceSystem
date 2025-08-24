using ProductService.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<CategoryDTO?> GetByIdAsync(Guid id);
        Task<List<CategoryDTO>> GetAllAsync();

        Task<CategoryDTO?> AddAsync(CategoryCreateDTO createDto);
        Task<CategoryDTO?> UpdateAsync(CategoryUpdateDTO updateDto);
        Task<bool> DeleteAsync(Guid id);






    }
}
