using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService.Application.DTOs
{
    public class EmailDTO
    {
        [Required(ErrorMessage = "Email is required.")]

        [EmailAddress(ErrorMessage = "Invalid email address format.")]

        public string Email { get; set; } = null!;
    }
}
