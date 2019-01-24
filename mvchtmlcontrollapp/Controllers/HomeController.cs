using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvchtmlcontrollapp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult validate(FormCollection f)
        {
            TempData["uname"] = f["txtUsername"];
            return RedirectToAction("welcome","secure");
        }


    }
}