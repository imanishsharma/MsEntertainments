
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class homeController : Controller
    {
        //
        // GET: /home/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult ContactUs()
        {
            return View();
        }
        public ActionResult UpcomingMovies()
        {
            string[]    UpcomingMovies = { "Man of steel", "World War Z", "Monsters University" };
            string[] StarCast = { "Henry Cavill,Amy Adams, Micheal Shannon, Diane Lane", "Brad Pitt, Mireille Enos, Daniella Kertesz, Matthew Fox", "Billy Crystal, John Goodman, Steve Buscemi, Helen Mirren " };
            ViewBag.names = UpcomingMovies;
            ViewBag.starcast = StarCast;
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}
