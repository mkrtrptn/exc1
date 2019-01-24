using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcmoviesgalleryapp.Models;

namespace mvcmoviesgalleryapp.Controllers
{
    public class MovieController : Controller
    {
        MovieDAL dalobj = new MovieDAL();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Store(MovieModel m )
        {
            m.moviefile = m.movieid + ".mp4";
            HttpPostedFileBase hb = Request.Files["fu1"];
            string filepath = Server.MapPath("/videos/") + m.moviefile;
            hb.SaveAs(filepath);

            dalobj.AddMovie(m);
            return View("Index");
        }

        public ActionResult Display()
        {
            List<MovieModel> movies = movies = dalobj.GetMovies();
            //int a = sum(a,b)
            //movies =  dalobj.GetMovies();
            return View(movies);
        }

    }
}