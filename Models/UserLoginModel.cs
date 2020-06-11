using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace UserRegistration.Models
{
    public class UserLoginModel
    {
        [Required, MaxLength(25)]
        public string UserName { get; set; }

        [Required, MinLength(6), MaxLength(20)]
        public string Password { get; set; }
    }
}
