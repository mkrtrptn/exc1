using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvchtmlcontrollapp.Controllers
{
    public class SecureController : Controller
    {
        // GET: Secure
        public ActionResult welcome()
        {
            return View();
        }

        public ActionResult close()
        {
            return View();
        }


    }
}