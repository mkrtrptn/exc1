using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcapplicationobjectapp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult post()
        {

            HttpContext.Application["comments"] = HttpContext.Application["comments"].ToString() + Request.Form["txtarea"] + "<hr/>" ;
            return View("Index");
        }


    }
}