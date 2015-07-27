using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpodIglyMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult StaticContent(string viewname)
        {
            return View(viewname);
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}