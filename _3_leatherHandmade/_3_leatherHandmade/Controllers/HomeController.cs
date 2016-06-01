using _3_leatherHandmade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3_leatherHandmade.Controllers
{
    public class HomeController : Controller
    {
        LeatherContext db = new LeatherContext ( );

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About ( )
        {
            IEnumerable<LeatherItem> items = db.LeatherItems;
            ViewBag.LeatherItems = items;

            return View ( );
        }

        public ActionResult Contact ( )
        {
            return View ( );
        }
    }
}