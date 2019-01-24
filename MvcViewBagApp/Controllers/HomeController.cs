using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcViewBagApp.Controllers
{
    public class HomeController : Controller
    {
     
        public ActionResult Index()
        {
            List<string> obj = new List<string>();
            obj.Add("MVC");
            obj.Add("Angular");
            obj.Add("Asp.net");


            List<int> acnumber =new List<int>();
            acnumber.Add(100);
            acnumber.Add(200);
            acnumber.Add(300);

            ViewBag.courses = obj;
            ViewData["acno"] = acnumber;

            return View();
        }
    }
}