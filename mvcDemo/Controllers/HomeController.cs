using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewData["Contries"] = new List<string>()
            {
                "Egypt",
                "England",
                "Germany",
                "Catalunia",
                "France"
            };
            return View();
        }

    }
}
