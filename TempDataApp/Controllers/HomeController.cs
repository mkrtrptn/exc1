using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TempDataApp.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult storetempdata()
        {
            TempData["n"] = 100;
            return View("Index");
        }

        public ActionResult peekread()
        {
            return View();
        }

        public ActionResult readandkeep()
        {
            return View();
        }


        public ActionResult normalread()
        {
            return View();
        }

        public ActionResult finalread()
        {
            return View();
        }


    }
}