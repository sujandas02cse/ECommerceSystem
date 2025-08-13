﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.Application.DTOs
{
    public class CategoryCreateDTO
    {
        [Required(ErrorMessage = "Category Name is required.")]

        [StringLength(100, ErrorMessage = "Category Name cannot exceed 100 characters.")]

        public string Name { get; set; } = null!;

        [StringLength(500, ErrorMessage = "Category Description cannot exceed 500 characters.")]

        public string? Description { get; set; }

        public Guid? ParentCategoryId { get; set; }

        public bool IsActive { get; set; }
    }
}
