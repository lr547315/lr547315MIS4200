using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lr547315MIS4200.Models
{
    public class customer
    {
        public int customerId { get; set; }

        [Display(Name ="First Name")]
        public string customerFirstName { get; set; }
        
        [Display(Name = "Last Name")]
        public string customerLastName { get; set; }

        [Display(Name = "Email")]
        public string email { get; set; }

        [Display(Name = "Phone Number")]
        public string phone { get; set; }

        public DateTime customerSince { get; set; }
        public ICollection<Orders> Orders { get; set; }
        public string fullName { 
            get
            {
                return customerLastName + ", " + customerFirstName;
            }
                }
    }
}