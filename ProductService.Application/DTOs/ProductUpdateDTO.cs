﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.Application.DTOs
{
    public class ProductUpdateDTO
    {
        [Required(ErrorMessage = "Product id is required.")]

        public Guid Id { get; set; }



        [Required(ErrorMessage = "Product Name is required.")]

        [StringLength(150, ErrorMessage = "Product Name cannot exceed 150 characters.")]

        public string Name { get; set; } = null!;



        [StringLength(1000, ErrorMessage = "Description cannot exceed 1000 characters.")]

        public string? Description { get; set; }



        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than zero.")]

        public decimal Price { get; set; }



        [Range(0, 1000, ErrorMessage = "Stock Quantity cannot be negative.")]

        public int StockQuantity { get; set; }

        public bool IsActive { get; set; }



        [Required(ErrorMessage = "Category ID is required.")]

        public Guid CategoryId { get; set; }
    }
}
