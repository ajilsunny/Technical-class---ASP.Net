using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Registration.Models
{
    public class Student
    {

        public string StudentId { get; set; }

        public string UserdemoId { get; set; }
        public virtual Userdemo Userdemo { get; set; }


        [Required]
        [Display(Name = "Enter Student Name")]
        [DataType(DataType.Text, ErrorMessage = "Please fill")]
        public string sname { get; set; }

        [Required]
        [Display(Name = "Enter student email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please fill")]
        public string semail { get; set; }

        public Gender Genderlist { get; set; }

    }
    public enum Gender
    {
        Male,
        Fmale
    }
}