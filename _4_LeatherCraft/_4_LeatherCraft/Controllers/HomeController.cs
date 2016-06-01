using _4_LeatherCraft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace _4_LeatherCraft.Controllers
{
    public class HomeController : Controller
    {
        LeatherContext db = new LeatherContext ( );



        // GET: Home
        public ActionResult Index ( )
        {
            return View ( );
        }

        //---------------------------------------------------

        public ActionResult About ( )
        {
            IEnumerable<LeatherItem> items = db.LeatherItems;
            ViewBag.LeatherItems = items;

            return View ( );
        }



        public ActionResult DownloadFile ( )
        {
            //string fileName = Server.MapPath ( "/Content/hedgehog.pdf" );
            //string contentType = "application/pdf";
            //string downloadName = "PDF Hedgehog.pdf";

            //string fileName = Server.MapPath ( "/Content/Hayloft.txt" );
            //string contentType = "application/txt";
            //string downloadName = "TXT Hayloft.txt";

            string fileName = Server.MapPath ( "/Content/Hayloft.doc" );
            string contentType = "application/doc";
            string downloadName = "Doc Hayloft.doc";

            return File ( fileName, contentType, downloadName );
        }



        public ActionResult DownloadBytes ( )
        {
            string filename = Server.MapPath ( "/Content/hedgehog.pdf" );
            string contentType = "application/pdf";
            byte [ ] data = System.IO.File.ReadAllBytes ( filename );
            return File ( data, contentType );
        }



        public ActionResult DownloadStream ( )
        {
            //string filename = Server.MapPath ( "/Content/hedgehog.pdf" );
            //string contentType = "application/pdf";
            //FileStream stream = System.IO.File.OpenRead ( filename );

            string filename = Server.MapPath ( "/Content/Hayloft.txt" );
            string contentType = "application/txt";
            FileStream stream = System.IO.File.OpenRead ( filename );
            string downloadName = "TXT Hayloft.txt";

            return File ( stream, contentType, downloadName );
        }


        //---------------------------------------------------

        [HttpGet]
        public ActionResult Contact ( )
        {
            return View ( );
        }



        [HttpPost]
        public ActionResult Contact ( Visitor visitor )
        {
            //if ( visitor.Age < 18 || visitor.Age > 100 )
            //{
            //    return HttpNotFound ( );
            //}

            //if (    validateName ( visitor.FirstName ) == false ||
            //        validateName ( visitor.LastName ) == false ||
            //        validateEmail ( visitor.Email ) == false ||
            //        validatePhone ( visitor.Phone ) == false )
            //{
            //    return RedirectToAction ( "Error", "Respond" );
            //}    

            //if ( string.IsNullOrEmpty ( visitor.FirstName ) )
            //{
            //    ModelState.AddModelError ( "FirstName", "The FirstName field is required" );
            //}
            //if ( string.IsNullOrEmpty ( visitor.LastName ) )
            //{
            //    ModelState.AddModelError ( "LastName", "The LastName field is required" );
            //}
            //if ( visitor.Age < 18 || visitor.Age > 100 )
            //{
            //    return HttpNotFound ( );
            //}

            if ( ModelState.IsValid )
            {
                return RedirectToAction ( "Thanks", "Respond", visitor );
            }
            //return RedirectToAction ( "Error", "Respond" );
            return View();
        }



        //private bool validateName ( string userName )
        //{
        //    Regex reg = new Regex ( @"^[A-Z][a-z]+$" );
        //    if ( reg.IsMatch ( userName ) == false )
        //    {
        //        return false;
        //    }
        //    return true;
        //}



        //private bool validateEmail ( string userEmail )
        //{
        //    Regex reg = new Regex ( @"^\w\w*@\w+\.[a-z]{2,4}$" );
        //    if ( reg.IsMatch ( userEmail ) == false )
        //    {
        //        return false;
        //    }
        //    return true;
        //}



        //private bool validatePhone ( string userPhone )
        //{
        //    Regex reg = new Regex ( @"^[+0-9\(\)][0-9\-\(\)]{3,20}[0-9]$" );
        //    if ( reg.IsMatch ( userPhone ) == false )
        //    {
        //        return false;
        //    }
        //    return true;
        //}
    }
}