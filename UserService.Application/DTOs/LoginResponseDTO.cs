﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService.Application.DTOs
{
    public class LoginResponseDTO
    {
        public bool Succeeded { get; set; }

        public string? Token { get; set; }

        public string? RefreshToken { get; set; }

        public bool RequiresTwoFactor { get; set; }

        public string? ErrorMessage { get; set; }

        public int? RemainingAttempts { get; set; }
    }
}
