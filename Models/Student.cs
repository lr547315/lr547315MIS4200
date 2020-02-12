using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lr547315MIS4200.Models
{
    public class Student
    {
        public int studentID { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        [Required(ErrorMessage = "Student email is required.")]
        [Display(Name = "Student Email")]
        public string email { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [Display(Name = "Student Phone Number")]
        public string phone { get; set; }

        [Required(ErrorMessage = "Date of enrollment is required.")]
        [Display(Name = "Student Enrollment Date")]
        public DateTime studentSince { get; set; }
        public ICollection<Enrollment> Enrollment { get; set; }
        public string fullName
        {
            get
            {
                return lastName + ", " + firstName;
            }
        }
    }
}