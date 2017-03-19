using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationMVC.Models
{
    public class Attendance
    {
        [Key]
        public int Id { get; set; }

        public int StudentId { get; set; }

        public virtual Student Student { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public bool Present { get; set; }

    }
}