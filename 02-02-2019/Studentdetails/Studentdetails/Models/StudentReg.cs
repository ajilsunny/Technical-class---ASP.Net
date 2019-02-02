using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Studentdetails.Models
{
    public class StudentReg
    {
        public int StudentRegId { get; set; }

        [Required]
        [Display(Name ="Enter Your name")]
        [DataType(DataType.Text,ErrorMessage ="Please enter valid name")]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Enter Your email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please enter valid email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Enter Your phone number")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Please enter valid phone number")]
        public string phone { get; set; }

        [Required]
        [Display(Name = "Enter Your password")]
        [DataType(DataType.Password, ErrorMessage = "Please enter valid password")]
        public string password { get; set; }
    }
}