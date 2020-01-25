using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TopEmployee.Dtos
{
    public class EmployeeDto
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}