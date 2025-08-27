using ProductService.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.Application.Interfaces
{
    public interface IReviewService
    {
        Task<List<ReviewDTO>> GetByProductIdAsync(Guid productId);

        Task<ReviewDTO?> GetByIdAsync(Guid reviewId);

        Task<ReviewDTO?> AddAsync(ReviewCreateDTO createDto);

        Task<ReviewDTO?> UpdateAsync(ReviewUpdateDTO updateDto);

        Task DeleteAsync(Guid reviewId);
    }
}
