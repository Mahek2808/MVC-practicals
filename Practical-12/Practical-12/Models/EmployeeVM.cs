using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical_12.Models
{
    public class EmployeeVM
    {
        public string FirstName { get; set; }

        [Required]
        public string MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Required]
        [StringLength(10)]
        public string Mobile { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Address { get; set; }

        public decimal Salary { get; set; }

        public IEnumerable<SelectListItem> Designations { get; set; }
    }
}