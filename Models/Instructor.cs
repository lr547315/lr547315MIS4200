using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lr547315MIS4200.Models
{
    public class Instructor
    {
        public int instructorID { get; set; }

        [Required(ErrorMessage = "Please include your name.")]
        [Display(Name = "Instructor Name")]
        public string instructorName { get; set; }

        [Required(ErrorMessage = "A short bio is required.")]
        [Display(Name = "Instructor Bio")]
        public string instructorBio { get; set; }

        // add any other fields as appropriate
        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        //we indicate that with an ICollection
        public ICollection<Enrollment> Enrollment { get; set; }
    }
}