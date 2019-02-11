using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mvcDemo.Models
{
    [Table("tblDepartment")]
    public class Department
    {
        public int departmentId { get; set; }
        public string name { get; set; }
        public List<Employee> employees { get; set; }  // every department has a collection of employees 
    }
}