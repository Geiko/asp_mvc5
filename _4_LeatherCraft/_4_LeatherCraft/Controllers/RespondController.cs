using _4_LeatherCraft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _4_LeatherCraft.Controllers
{
    public class RespondController : Controller
    {
        // GET: Respond
        public ActionResult Thanks ( Visitor visitor)
        {
            return View ( visitor );
        }

        public ActionResult Error ( )
        {
            return View ( );
        }
    }
}