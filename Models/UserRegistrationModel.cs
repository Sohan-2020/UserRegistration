using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Serialization;
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

        [RegularExpression(@".*[A-Za-z]",ErrorMessage = "The First Name should not have any numeric character or special character.")]
        [Required, MaxLength(50)]
        [Display(Name = "First Name:")]
        public string FirstName { get; set; }

        [RegularExpression(@".*[A-Za-z]", ErrorMessage = "The Last Name should not have any numeric character or special character.")]
        [Required, MaxLength(50)]
        [Display(Name = "Last Name:")]
        public string LastName { get; set; }

        [Required, MaxLength(25)]
        [Display(Name = "User Name:")]
        public string UserName { get; set; }

        [RegularExpression(@"^.*(?=.{6,})(?=.*\d)(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$", ErrorMessage = " 1- The Length should be of minimum 6 characters. 2- The password should have atleast 1 special character, 1 numeric character and  1 capital character.")]
        [Required,MinLength(6),MaxLength(20)]
        [DataType(DataType.Password)]
        [Display(Name = "Password:")]
        public string Password { get; set; }

        [Display(Name = "Location:")]
        public string Location { get; set; }

        [Range(1000000000, 9999999999,ErrorMessage ="The mobile number should be of 10 digit.")]
        [Display(Name = "Mobile No:")]
        public long MobileNo { get; set; }

        [Display(Name = "DOB:")]
        public DateTime DOB { get; set; }

        [Display(Name = "Gender:")]
        public string Gender { get; set; }

    }
}
