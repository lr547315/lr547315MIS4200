using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lr547315MIS4200.Models
{
    public class Enrollment
    {
        public int enrollmentID { get; set; }
        public string enrollmentName { get; set; }
        public string enrollmentDescription { get; set; }
        public DateTime enrollmentTime { get; set; }
        public int courseID { get; set; }
        public virtual Course Course { get; set; }
        public int instructorID { get; set; }
        public virtual Instructor Instructor { get; set; }
    }
}