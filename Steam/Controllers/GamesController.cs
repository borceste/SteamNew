﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Steam.Models;

namespace Steam.Controllers
{
    public class GamesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Games
        public ActionResult Index()
        {





            return View(db.Games.ToList());
        }

        // GET: Games/Details/5
        public ActionResult Details(int? id)
        {
            //List<Game> listGames = db.Games.ToList();

            List<Review> listReviews = db.Reviews.Where(x => x.GameId == id).ToList();
           
            List<GameImage> gameImages = db.GameImages.Where(x => x.GameId == id).ToList();

            List<ApplicationUser> users = db.Users.ToList();

            ViewData["listReviews"] = listReviews;
            ViewData["gameImages"] = gameImages;
            ViewData["users"] = users;



            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Game game = db.Games.Find(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }

        // GET: Games/Create

        [HttpGet]
        public ActionResult AddWishlistedGame(int GameId, string UserId)
        {
            var model = new UserWishlistedGame();
            model.GameId = GameId;
            model.UserId = UserId;
            return View(model);
        }
        [HttpPost]
        public ActionResult AddWishlistedGame(UserWishlistedGame model)
        {
            var search = db.UserWishlistedGames.Find(model.GameId, model.UserId);
            if (search == null)
            {
                db.UserWishlistedGames.Add(model);
            }
            db.SaveChanges();

            return RedirectToAction("Index","Home");
        }

        [HttpGet]
        public ActionResult AddOwnedGame(int GameId, string UserId)
        {
            var model = new UserOwnedGame();
            model.GameId = GameId;
            model.UserId = UserId;

            return View(model);
        }
        [HttpPost]
        public ActionResult AddOwnedGame(UserOwnedGame model)
        {
            var search = db.UserOwnedGames.Find(model.GameId, model.UserId);
            if(search == null)
            {
                db.UserOwnedGames.Add(model);
            }
            var gameToUpdate = db.Games.Find(model.GameId);
            int solded = gameToUpdate.getSold();
            gameToUpdate.setSold(solded + 1);

            db.Games.AddOrUpdate(gameToUpdate);

            db.SaveChanges();

            return RedirectToAction("Index","Home");
        }
        public ActionResult Create()
        {
            return View();
        }

        // POST: Games/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GameId,name,price,coverImage,description,developer,rating,sold,discount,dateAdded")] Game game)
        {
            if (ModelState.IsValid)
            {
                db.Games.Add(game);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(game);
        }

        // GET: Games/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Game game = db.Games.Find(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }

        // POST: Games/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GameId,name,price,coverImage,description,developer,rating,sold,discount,dateAdded")] Game game)
        {
            if (ModelState.IsValid)
            {
                db.Entry(game).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(game);
        }

        // GET: Games/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Game game = db.Games.Find(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }

        // POST: Games/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Game game = db.Games.Find(id);
            db.Games.Remove(game);
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
