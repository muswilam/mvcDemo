using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcDemo.Models;

namespace mvcDemo.Controllers
{
    public class EmployeesController : Controller
    {
        //
        // GET: /Employees/

        public ActionResult Details(int id) // should name this parmeter with 'id' because of default rout or use (?ur_parmeter=num)
        {
            // make instance from classContext then retrieve just one row by 'single' 
            EmployeeContext employeeContext = new EmployeeContext();
            Employee employees = employeeContext.employee.Single(emp => emp.id == id);
            return View(employees);
        }

    }
}
