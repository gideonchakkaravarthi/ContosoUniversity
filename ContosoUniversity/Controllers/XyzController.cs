using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContosoUniversity.Models;

namespace ContosoUniversity.Controllers
{
    public class XyzController : Controller
    {
        // GET: Xyz
        public ActionResult Abc()
        {
            Student alex = new Student();
            alex.FirstName = "Arun";
            alex.LastName = "Kumar";

            Student arun = new Student();
            alex.FirstName = "Raj";
            alex.LastName = "Kumar";

            Student arjun = new Student();
            alex.FirstName = "Arjun";
            alex.LastName = "Kumar";

            Student ragu = new Student();
            alex.FirstName = "Ragu";
            alex.LastName = "Raj";

            Student ram = new Student();
            alex.FirstName = "Ram";
            alex.LastName = "Kumar";

            List<Student> students = new List<Student>();
            students.Add(alex);
            students.Add(arun);
            students.Add(arjun);
            students.Add(ragu);
            students.Add(ram);
            return View (students);
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}