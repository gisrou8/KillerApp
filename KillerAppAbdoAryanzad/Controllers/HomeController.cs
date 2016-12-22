using KillerAppAbdoAryanzad.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KillerAppAbdoAryanzad.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MSSQLTypeDrugsContext test = new MSSQLTypeDrugsContext();
            test.GetAll();
            return View();
        }

        public ActionResult Wiet()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Hasj()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}