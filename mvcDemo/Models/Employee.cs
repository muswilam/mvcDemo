using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mvcDemo.Models
{
    [Table("tblEmployee")] // mapping database table
    public class Employee
    {
       
        [Key] public int id { get; set; } // primary key
        public string name { get; set; }
        public int age { get; set; }
        public string City { get; set; }
        public int departmentId { get; set; }
    }
}