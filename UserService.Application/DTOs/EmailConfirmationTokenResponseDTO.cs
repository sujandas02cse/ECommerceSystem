﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService.Application.DTOs
{
    public class EmailConfirmationTokenResponseDTO
    {
        public Guid UserId { get; set; }

        public string Token { get; set; } = null!;
    }
}
