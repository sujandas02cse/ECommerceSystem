using ProductService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.Domain.Repostitories
{
    public interface IReviewRepository
    {
        Task<List<Review>> GetReviewsByProductIdAsync(Guid productId);

        Task<Review?> GetReviewByIdAsync(Guid reviewId);

        Task<Review?> AddReviewAsync(Review review);

        Task<Review?> UpdateReviewAsync(Review review);

        Task DeleteReviewAsync(Guid reviewId);
    }
}
