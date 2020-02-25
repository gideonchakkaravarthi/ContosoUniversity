using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContosoUniversity.Models;
using ContosoUniversity.ViewModels;

namespace ContosoUniversity.Controllers
{
    public class XyzController : Controller
    {
        private SchoolContext db = new SchoolContext();
        public ActionResult Abc()
        {
            var students = db.students.ToList();
            return View(students);

            //Course c1 = new Course();
            //c1.CourseName = "Maths";
            //c1.TotalCredits = "4";

            //Student alex = new Student();
            //alex.FirstName = "Arun";
            //alex.LastName = "Kumar";

            //Student arun = new Student();
            //arun.FirstName = "Raj";
            //arun.LastName = "Kumar";

            //Student arjun = new Student();
            //arjun.FirstName = "Arjun";
            //arjun.LastName = "Kumar";

            //Student ragu = new Student();
            //ragu.FirstName = "Ragu";
            //ragu.LastName = "Raj";

            //Student ram = new Student();
            //ram.FirstName = "Ram";
            //ram.LastName = "Kumar";

            //List<Student> students = new List<Student>();
            //students.Add(alex);
            //students.Add(arun);
            //students.Add(arjun);
            //students.Add(ragu);
            //students.Add(ram);
            //Course_Students obj = new Course_Students();
            //obj.course = c1;
            //obj.students = students;
            //return View (obj);
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
 