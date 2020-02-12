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

        [Required(ErrorMessage = "Please include the name you used for enrollment.")]
        [Display(Name = "Enrollment Name")]
        public string enrollmentName { get; set; }

        [Required(ErrorMessage = "Enrollment date is required.")]
        [Display(Name = "Enrollment Date")]
        public DateTime enrollmentDate { get; set; }

        [Required(ErrorMessage = "Course name is required.")]
        [Display(Name = "Course Name")]
        public string courseName { get; set; }
        public virtual Course Course { get; set; }

        [Display(Name = "Instructor Name")]
        public string instructorName { get; set; }
        public virtual Instructor Instructor { get; set; }
    }
}