using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Common.Models
{
   public class RegisterModel
    {


        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name ="MobileNumber")]
        [Remote("IsPhoneInUse","Auth",HttpMethod ="POST",AdditionalFields = "__RequestVerificationToken")]
        public string MobileNumber { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The password and confirmation password do not match.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string ConfirmPassword { get; set; }


    }
}
