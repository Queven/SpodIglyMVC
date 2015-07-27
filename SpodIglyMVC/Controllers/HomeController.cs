using SpodIglyMVC.DAL;
using SpodIglyMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpodIglyMVC.Controllers
{
    public class HomeController : Controller
    {
        private StoreContext db = new StoreContext();
        // GET: Home
        public ActionResult StaticContent(string viewname)
        {
            return View(viewname);
        }
        public ActionResult Index()
        {
            var genresList = db.Genres.ToList();
            return View();
        }
    }
}