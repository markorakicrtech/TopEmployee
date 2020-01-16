using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TopEmployee.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}