using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcdynamicpartialview.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult contact()
        {
            return View();
        }

        public ActionResult about()
        {
            return View();
        }

        public ActionResult services()
        {
            return View();
        }

        public PartialViewResult header()
        {
            List<string> pages =new List<string>();
            pages.Add("index");
            pages.Add("contact");
            pages.Add("about");
            pages.Add("services");

            ViewBag.pages = pages;

            return PartialView("_header");
        }



    }
}