﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService.Application.DTOs
{
    public class RefreshTokenResponseDTO
    {
        public string? Token { get; set; }

        public string? RefreshToken { get; set; }

        public string? ErrorMessage { get; set; }
    }
}
