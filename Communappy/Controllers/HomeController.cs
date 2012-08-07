using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Communappy.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "If you had unlimited developer resources to build a website how would you changes the world?";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
