using _1WatchStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1WatchStore.Controllers
{
    public class HomeController : Controller
    {
        WatchContext db = new WatchContext ( );
        // GET: Home
        public ActionResult Index()
        {
            IEnumerable<Watch> watches = db.Watches;
            ViewBag.Watches = watches;

            return View();
        }
    }
}