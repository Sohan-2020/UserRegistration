using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserRegistration.Models
{
    public class UserRegistrationModel
    {
        [Key]
        public int Id { get; set; }

        [Required,MaxLength(50)]
        public string FirstName { get; set; }

        [Required, MaxLength(50)]
        public string LastName { get; set; }

        [Required, MaxLength(25)]
        public string UserName { get; set; }

        [Required,MinLength(6),MaxLength(20)]
        public string Password { get; set; }

        [MaxLength(20)]
        public string Location { get; set; }

        public long MobileNo { get; set; }

        public DateTime DOB { get; set; }

        [MaxLength(10)]
        public string Gender { get; set; }

    }
}
