using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asp_mvc_kudvenkat.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult  Index()
        {
            ViewBag.JayCountry = new List<string>()
            {
                "india",
                "us", 
                "uk",
                "canada"
            };

            ViewData["1stworld"] = new List<string>()
            {
                "US",
                "Uk",
                "Uganda"
            };

            return View();
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

        public string MvcVersion()
        {
            return typeof(Controller).Assembly.GetName().Version.ToString();
        }
    }
}