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
        
        [Display(Name = "First Name")]
        public string firstName { get; set; }
        
        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        [Display(Name = "Student Email")]
        public string email { get; set; }

        [Display(Name = "Student Phone Number")]
        public string phone { get; set; }

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