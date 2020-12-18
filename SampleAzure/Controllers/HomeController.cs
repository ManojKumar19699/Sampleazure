using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleAzure.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Manoj Kumar 19699";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Im recreating";

            return View();
        }
    }
}