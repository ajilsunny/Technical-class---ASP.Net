using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Studentdetails.Models
{
    public class Studentinfo
    {
        public int StudentinfoId { get; set; }

        public int StudentdeptId { get; set; }
        public virtual Studentdept Studentdept { get; set; }

        [Required]
        [Display(Name ="Enter subjct")]
        [DataType(DataType.Text)]
        public string studsubject { get; set; }

        [Required]
        [Display(Name = "Enter Mark")]
        [DataType(DataType.PhoneNumber)]
        public string studmark { get; set; }
    }
}