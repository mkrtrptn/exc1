using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvccookieapp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            if(Request.Cookies["visit"] ==null)
            {
                //first visit
                ViewBag.msg = "This Is your First Visit To Site";
                Response.Cookies["visit"].Value = DateTime.Now.ToString();
                Response.Cookies["visit"].Expires = DateTime.Now.AddDays(4);
            }
            else
            {
                //last Visit
                ViewBag.msg = "Last Visit : " + Request.Cookies["visit"].Value;
                Response.Cookies["visit"].Value = DateTime.Now.ToString();
                Response.Cookies["visit"].Expires = DateTime.Now.AddDays(4);

            }

            return View();
        }
    }
}