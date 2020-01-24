using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Steam.Models;

namespace Steam.Controllers
{
    public class GameImagesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: GameImages
        public ActionResult Index()
        {
            var gameImages = db.GameImages.Include(g => g.Game);
            return View(gameImages.ToList());
        }

        // GET: GameImages/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameImage gameImage = db.GameImages.Find(id);
            if (gameImage == null)
            {
                return HttpNotFound();
            }
            return View(gameImage);
        }

        // GET: GameImages/Create
        public ActionResult Create()
        {
            ViewBag.GameId = new SelectList(db.Games, "GameId", "name");
            return View();
        }

        // POST: GameImages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GameImageId,GameId,UrlString")] GameImage gameImage)
        {
            if (ModelState.IsValid)
            {
                db.GameImages.Add(gameImage);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GameId = new SelectList(db.Games, "GameId", "name", gameImage.GameId);
            return View(gameImage);
        }

        // GET: GameImages/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameImage gameImage = db.GameImages.Find(id);
            if (gameImage == null)
            {
                return HttpNotFound();
            }
            ViewBag.GameId = new SelectList(db.Games, "GameId", "name", gameImage.GameId);
            return View(gameImage);
        }

        // POST: GameImages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GameImageId,GameId,UrlString")] GameImage gameImage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gameImage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GameId = new SelectList(db.Games, "GameId", "name", gameImage.GameId);
            return View(gameImage);
        }

        // GET: GameImages/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameImage gameImage = db.GameImages.Find(id);
            if (gameImage == null)
            {
                return HttpNotFound();
            }
            return View(gameImage);
        }

        // POST: GameImages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GameImage gameImage = db.GameImages.Find(id);
            db.GameImages.Remove(gameImage);
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
