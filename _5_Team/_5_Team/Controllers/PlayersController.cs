using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _5_Team.Models;

namespace _5_Team.Controllers
{
    public class PlayersController : Controller
    {
        private SoccerContext db = new SoccerContext();

        // GET: Players
        public ActionResult Index(int? team, Position? position, PlayerSortInfo info )
        {
            var players = db.Players.Include(p => p.Team);
            if(team != null && team != 0 )
            {
                players = players.Where ( p => p.TeamId == team );
            }
            if (position != null && !position.Equals( Position.All ))
            {
                players = players.Where ( p => p.Position == position );
            }

            List<Team> teams = db.Teams.ToList();
            teams.Insert ( 0, new Team { Name = "All" } );
            ViewBag.Teams = teams;
            
            var positions = Enum.GetValues ( typeof ( Position ) );
            ViewBag.Positions = new SelectList ( positions );

            if( info == null )
            {
                return View ( players.ToList ( ) );
            }

            switch ( info.SortField )
            {
                case "TeamName":
                    players = players.OrderBy ( p => p.Team.Name );
                    break;
                case "FirstName":
                    players = players.OrderBy ( p => p.FirstName );
                    break;
                case "LastName":
                    players = players.OrderBy ( p => p.LastName );
                    break;
                case "Position":
                    players = players.OrderBy ( p => p.Position );
                    break;
                case "Birthday":
                    players = players.OrderBy ( p => p.Birthday );
                    break;
            }
            ViewBag.SortingInfo = info;
            List<Player> model = players.ToList ( );            
            return View (model);
        }


        
        // GET: Players/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Player player = db.Players.Find(id);
            if (player == null)
            {
                return HttpNotFound();
            }
            return View(player);
        }

        // GET: Players/Create
        public ActionResult Create()
        {
            ViewBag.TeamId = new SelectList(db.Teams, "Id", "Name");
            return View();
        }

        // POST: Players/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,Position,Birthday,TeamId")] Player player)
        {
            if (ModelState.IsValid)
            {
                db.Players.Add(player);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TeamId = new SelectList(db.Teams, "Id", "Name", player.TeamId);
            return View(player);
        }

        // GET: Players/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Player player = db.Players.Find(id);
            if (player == null)
            {
                return HttpNotFound();
            }
            ViewBag.TeamId = new SelectList(db.Teams, "Id", "Name", player.TeamId);
            return View(player);
        }

        // POST: Players/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Position,Birthday,TeamId")] Player player)
        {
            if (ModelState.IsValid)
            {
                db.Entry(player).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TeamId = new SelectList(db.Teams, "Id", "Name", player.TeamId);
            return View(player);
        }

        // GET: Players/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Player player = db.Players.Find(id);
            if (player == null)
            {
                return HttpNotFound();
            }
            return View(player);
        }

        // POST: Players/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Player player = db.Players.Find(id);
            db.Players.Remove(player);
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
