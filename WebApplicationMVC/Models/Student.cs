using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationMVC.Models
{
    public enum Gender
    {
        Male,
        Female,
        Other
    }

    public class Student
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100), Required]
        public string Name { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public Gender Gender { get; set; }

        public int Rank { get; set; }

        public virtual IEnumerable<Attendance> Attendance { get; set; }

    }
}