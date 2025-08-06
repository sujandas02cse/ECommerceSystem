﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService.Application.DTOs
{
    public class ResetPasswordDTO
    {
        [Required(ErrorMessage = "User ID is required.")]

        public Guid UserId { get; set; }



        [Required(ErrorMessage = "Token is required.")]

        public string Token { get; set; } = null!;



        [Required(ErrorMessage = "New password is required.")]

        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password must be at least 8 characters.")]

        public string NewPassword { get; set; } = null!;
    }
}
