using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practical_12.Models
{
    public class Designation
    {
        [Key]
        public int Designation_id { get; set; }

        [Required]
        [Display(Name ="Designation")]
        public string Desg_Name { get; set; }
    }
}