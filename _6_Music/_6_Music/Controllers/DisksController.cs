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
    public class DisksController : Controller
    {
        private MusicContext db = new MusicContext();

    

        // GET: Disks
        public ActionResult Index ( int? genre, int? artist )
        {
            var disks = db.Disks.Include ( d => d.Artist ).Include ( d => d.Genre );
            if ( genre != null && genre != 0 )
            {
                disks = disks.Where ( d => d.GenreId == genre );
            }
            if ( artist != null && artist != 0 )
            {
                disks = disks.Where ( d => d.ArtistId == artist );
            }
            List<Genre> genres = db.Genres.ToList ( );
            genres.Insert ( 0, new Genre { Name = "All" } );

            List<Artist> artists = db.Artists.ToList ( );
            artists.Insert ( 0, new Artist { Name = "All" } );

            DiskListViewModel dlvm = new DiskListViewModel
            {
                Disks = disks.ToList ( ),
                Genres = new SelectList ( genres, "Id", "Name" ),
                Artists = new SelectList ( artists, "Id", "Name" )
            };

            return View ( dlvm );
        }


        
        // GET: Disks/Details/5
        public ActionResult Details ( int? id )
        {
            if ( id == null )
            {
                return new HttpStatusCodeResult ( HttpStatusCode.BadRequest );
            }
            var disks = db.Disks.Include ( d => d.Artist ).Include ( d => d.Genre );
            Disk disk = disks.FirstOrDefault ( d => d.Id == id );
            if ( disk == null )
            {
                return HttpNotFound ( );
            }
            return View ( disk );
        }



        // GET: Disks/Create
        public ActionResult Create()
        {
            ViewBag.ArtistId = new SelectList(db.Artists, "Id", "Name");
            ViewBag.GenreId = new SelectList(db.Genres, "Id", "Name");
            return View();
        }



        // POST: Disks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ArtistId,GenreId,Title,Price,DiskUrl")] Disk disk)
        {
            if (ModelState.IsValid)
            {
                db.Disks.Add(disk);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ArtistId = new SelectList(db.Artists, "Id", "Name", disk.ArtistId);
            ViewBag.GenreId = new SelectList(db.Genres, "Id", "Name", disk.GenreId);
            return View(disk);
        }



        // GET: Disks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Disk disk = db.Disks.Find(id);
            if (disk == null)
            {
                return HttpNotFound();
            }
            ViewBag.ArtistId = new SelectList(db.Artists, "Id", "Name", disk.ArtistId);
            ViewBag.GenreId = new SelectList(db.Genres, "Id", "Name", disk.GenreId);
            return View(disk);
        }



        // POST: Disks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ArtistId,GenreId,Title,Price,DiskUrl")] Disk disk)
        {
            if (ModelState.IsValid)
            {
                db.Entry(disk).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ArtistId = new SelectList(db.Artists, "Id", "Name", disk.ArtistId);
            ViewBag.GenreId = new SelectList(db.Genres, "Id", "Name", disk.GenreId);
            return View(disk);
        }



        // GET: Disks/Delete/5
        public ActionResult Delete ( int? id )
        {
            if ( id == null )
            {
                return new HttpStatusCodeResult ( HttpStatusCode.BadRequest );
            }
            var disks = db.Disks.Include ( d => d.Artist ).Include ( d => d.Genre );
            Disk disk = disks.FirstOrDefault ( d => d.Id == id );
            if ( disk == null )
            {
                return HttpNotFound ( );
            }
            return View ( disk );
        }


        // POST: Disks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Disk disk = db.Disks.Find(id);
            db.Disks.Remove(disk);
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
