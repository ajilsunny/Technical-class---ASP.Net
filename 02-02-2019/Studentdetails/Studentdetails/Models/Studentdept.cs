using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Studentdetails.Models
{
    public class Studentdept
    {
        public int StudentdeptId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name ="Enter Department Name")]
        public string Deptname { get; set; }
    }
}