using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TopEmployee.Models
{
    public class Employee
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Name and surname")]
        public string Name { get; set; }
        [Display(Name = "Date of birth")]
        public DateTime Birthdate { get; set; }
        [Display(Name = "Username")]
        public string Username { get; set; }
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}