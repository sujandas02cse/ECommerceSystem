using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService.Application.DTOs
{
    public class DeleteAddressDTO
    {
        [Required(ErrorMessage = "User ID is required.")]

        public Guid UserId { get; set; }



        [Required(ErrorMessage = "Address ID is required.")]

        public Guid AddressId { get; set; }
    }
}
