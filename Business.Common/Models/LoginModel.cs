using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Common.Models
{
   public class LoginModel
    {
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string MobileNumber { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [Display(Name ="Remember me ?")]
        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }
        public IList<AuthenticationScheme> ExternalLogins { get; set; }


    }
}
