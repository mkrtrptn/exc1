using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcapp1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult content()
        {
            return Content("<h1> Asp.net MVC</h1>");
        }
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult about()
        {
            return View();
        }


        public ActionResult contact()
        {
            return View();
        }

    }
}