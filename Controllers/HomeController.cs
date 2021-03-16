using fırst_WebProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static fırst_WebProject.Models.facultyEntities4;

namespace fırst_WebProject.Controllers
{
    public class HomeController : Controller
    {
        facultyEntities4 db = new facultyEntities4();
        public ActionResult Index()
        {
            List<Department> list = db.Departments.ToList();
            return View(list);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Students(int id)
        {
            List<Student> StudentList = db.Students.Where(x => x.Department_Id == id).ToList();
            return View(StudentList);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}