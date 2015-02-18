using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using week5_person_app.Data;
using week5_person_app.Data.Model;
using week5_person_app.Models;

namespace week5_person_app.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Person> model;
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                model = db.People;
            }
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}