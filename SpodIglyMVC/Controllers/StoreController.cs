using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpodIglyMVC.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Detalis(int id)
        {
            return View();
        }
        public ActionResult List(string genrename)
        {
            return View();
        }
    }
}