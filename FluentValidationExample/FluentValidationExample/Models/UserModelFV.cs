using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FluentValidationExample.Models
{
    public class UserModelFV
    {
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Display(Name = "Address")]
        public List<string> AddressLines { get; set; } = new List<string>()
        {
            "",""
        };
    }
}