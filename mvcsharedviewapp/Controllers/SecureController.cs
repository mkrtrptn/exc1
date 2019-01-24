using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcsharedviewapp.Controllers
{
    public class SecureController : Controller
    {
        // GET: Secure
        public ActionResult Secure()
        {
            return View("error");
        }

        public ActionResult Welcome()
        {
            return View();
        }
    }
}