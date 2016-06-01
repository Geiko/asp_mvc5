using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _6_Music.Models;

namespace _6_Music.Controllers
{
    public class PurchasesController : Controller
    {
        private MusicContext db = new MusicContext();



        // GET: Purchases
        public ActionResult Index()
        {
            var purchase = db.Purchase.Include(p => p.Disk).Include ( p => p.Disk.Artist );
            return View(purchase.ToList());
        }



        // GET: Purchases/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var purchases = db.Purchase.Include ( p => p.Disk ).Include ( a => a.Disk.Artist );
            Purchase purchase = purchases.FirstOrDefault ( p => p.Id == id );
            if (purchase == null)
            {
                return HttpNotFound();
            }
            return View(purchase);
        }



        // GET: Purchases/Create
        //public ActionResult Create()
        //{
        //    ViewBag.DiskId = new SelectList(db.Disks, "Id", "Title");
        //    return View();
        //}
        public ActionResult Create ( int? id )
        {
            if ( id != null )
            {
                Disk selectedDisk = db.Disks.FirstOrDefault ( d => d.Id == id );
                ViewBag.SelectedDisk = selectedDisk;
                ViewBag.SelectedArtist = db.Artists.FirstOrDefault ( a => a.Id == selectedDisk.ArtistId );
                ViewBag.SelectedGenre = db.Genres.FirstOrDefault ( g => g.Id == selectedDisk.GenreId );
            }
            else
            {
                return HttpNotFound ( );
            }

            return View ( );
        }


        // POST: Purchases/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create ( [Bind ( Include = "Id,ShippingData,Date" )] Purchase purchase, int? selectedDiskId )
        {
            if ( ModelState.IsValid )
            {
                purchase.Date = DateTime.Now;
                Disk selectedDisk = db.Disks.FirstOrDefault ( d => d.Id == selectedDiskId );
                purchase.Disk = selectedDisk;
                purchase.Id = selectedDisk.Id;

                db.Purchase.Add ( purchase );
                db.SaveChanges ( );

                return RedirectToAction ( "Thanks" );
            }

            return View ( "Create" );
        }
        


        public ActionResult Thanks ( )
        {
            return View ( );
        }



        // GET: Purchases/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Purchase purchase = db.Purchase.Find(id);
            if (purchase == null)
            {
                return HttpNotFound();
            }
            ViewBag.DiskId = new SelectList(db.Disks, "Id", "Title", purchase.DiskId);
            return View(purchase);
        }



        // POST: Purchases/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ShippingData,Date,DiskId")] Purchase purchase)
        {
            if (ModelState.IsValid)
            {
                db.Entry(purchase).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DiskId = new SelectList(db.Disks, "Id", "Title", purchase.DiskId);
            return View(purchase);
        }



        // GET: Purchases/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var purchases = db.Purchase.Include ( p => p.Disk );
            Purchase purchase = purchases.FirstOrDefault ( p => p.Id == id );
            //Purchase purchase = db.Purchase.Find(id);
            if (purchase == null)
            {
                return HttpNotFound();
            }
            return View(purchase);
        }



        // POST: Purchases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Purchase purchase = db.Purchase.Find(id);
            db.Purchase.Remove(purchase);
            db.SaveChanges();
            return RedirectToAction("Index");
        }



        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
