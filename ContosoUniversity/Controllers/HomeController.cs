using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContosoUniversity.Controllers
{
    public class HomeController : Controller
    {
        //Action Method
        public string Index()
        {
            return "Hellow World";
        }

        public string About()
        {
            ViewBag.Message = "Your application description page.";

            return "This is the home Controller - About Method";
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}