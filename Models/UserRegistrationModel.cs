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

        [RegularExpression(@".*[A-Za-z]")]
        [Required, MaxLength(50)]
        public string FirstName { get; set; }

        [RegularExpression(@".*[A-Za-z]")]
        [Required, MaxLength(50)]
        public string LastName { get; set; }

        [Required, MaxLength(25)]
        public string UserName { get; set; }

        [RegularExpression(@"^.*(?=.{6,})(?=.*\d)(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$")]
        [Required,MinLength(6),MaxLength(20)]
        public string Password { get; set; }

       
        public string Location { get; set; }

        [Range(1000000000, 9999999999,ErrorMessage ="The mobile number should be of 10 digit.")]
        public long MobileNo { get; set; }

        public DateTime DOB { get; set; }

        
        public string Gender { get; set; }

    }
}
