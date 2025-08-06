using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.Domain.Entities
{
    public class ProductImage
    {
        [Key]

        public Guid Id { get; set; }

        [Required]

        public Guid ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]

        public Product? Product { get; set; }

        [Required, MaxLength(500)]

        public string ImageUrl { get; set; } = null!;

        public bool IsPrimary { get; set; }

        [MaxLength(250)]

        public string? AltText { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
