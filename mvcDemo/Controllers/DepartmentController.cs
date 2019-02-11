using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcDemo.Models;

namespace mvcDemo.Controllers
{
    public class DepartmentController : Controller
    {

        public ActionResult Index()
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<Department> department = employeeContext.department.ToList();
            return View(department);
        }

    }
}
