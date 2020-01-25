using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TopEmployee.Models
{
    public class AplicationDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public AplicationDBContext() : base("name=TopEmploeeConnection")
        {

        }
    }
}