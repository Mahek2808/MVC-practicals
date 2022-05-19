using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Practical_12.Models
{
    public class Employee
    {
        [Key]
        public int id { get; set; }
        [Required]
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

        public int Designation_id { get; set; }

        [ForeignKey("Designation_id")]
        public Designation Designation { get; set; }

    }
}