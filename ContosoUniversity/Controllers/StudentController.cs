using System.Web.Mvc;

namespace ContosoUniversity.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

    }
}