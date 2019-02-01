using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Registration.Models
{
    public class Userdemo
    {   

        public string UserdemoId { get; set; }

        [Required]
        [Display(Name ="Enter your Name")]
        [DataType(DataType.Text, ErrorMessage = "Please fill")]
        public string uname { get; set; }

        [Required]
        [Display(Name ="Enter your email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please fill")]
        public string email { get; set; }

        [Required]
        [Display(Name ="Enter your phone number")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Please fill")]
        public string phone { get; set; }

        [Required]
        [Display(Name ="Enter your password")]
        [DataType(DataType.Password,ErrorMessage ="Please fill")]
        public string password { get; set; }
    }
}