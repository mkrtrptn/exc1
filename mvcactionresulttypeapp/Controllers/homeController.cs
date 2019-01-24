using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcactionresulttypeapp.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            return View();
        }

        public ContentResult contentdemo()
        {
            return Content("<h2 >content Demo </h2>");
        }

        public ViewResult viewdemo()
        {
            return View();
        }

        public RedirectResult redirectdemo()
        {
            return Redirect("www.google.com");
        }

        public FileResult filedemo()
        {
            return File("~/images/abc.jpg","image/jpg","Download");
        }

        public RedirectToRouteResult routeresultdemo()
        {
           return  RedirectToAction("Index","Secure");
        }


    }
}