using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.Domain.Entities
{
    public class Review
    {
        [Key]

        public Guid Id { get; set; }

        [Required]

        public Guid ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]

        public Product? Product { get; set; }

        [Required]

        public Guid UserId { get; set; }  // Reference to user who wrote review 

        [Range(1, 5)]

        public int Rating { get; set; } // Usually 1 to 5 stars 

        [MaxLength(2000)]

        public string? Comment { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
