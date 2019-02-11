using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvcDemo.Models
{
    public class EmployeeContext : DbContext
    {
        // class require data from database and represent them 
        public DbSet<Employee> employee { get; set; }
        public DbSet<Department> department { get; set; }
    }
}