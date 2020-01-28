using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Serialization;

using Steam.Models;

namespace Steam.Controllers
{
    
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ApplicationDbContext SteamDb = new ApplicationDbContext();

            List<Game> gameList = SteamDb.Games.ToList();
                 

            return View(gameList);
        }
        
        public ActionResult ShowUsers()
        {

            ApplicationDbContext SteamDb = new ApplicationDbContext();
            List<ApplicationUser> users = SteamDb.Users.ToList();
            return View(users);
        }

        public PartialViewResult Tabs(String typeOfTab)
        {
            ApplicationDbContext dataClass = new ApplicationDbContext();
            List<Game> games = dataClass.Games.ToList();
            List<Game> result = null;
            switch (typeOfTab)
            {
                case "New":
                    result = (List<Game>)(from game in games
                              orderby game.dateAdded descending
                              select game).Take(10).ToList();
                    break;

                case "Top Selling":
                    
                    result = (List<Game>)(from game in games
                                          where game.price >= 15f
                                          select game).ToList();
                    result = (List<Game>)(from game in result
                                          orderby game.dateAdded descending
                                          select game).Take(200).ToList();
                    result = (List<Game>)(from game in result
                                          orderby game.sold descending
                                          select game).Take(10).ToList();
                    break;

                case "Specials":
                    result = (List<Game>)(from game in games
                                          where game.discount > 0
                                          select game).ToList();
                    result = (List<Game>)(from game in result
                                          orderby game.rating descending
                                          select game).Take(100).ToList();
                    result = (List<Game>)(from game in result
                                          orderby game.price ascending
                                          select game).Take(10).ToList();
                    break;
                default:
                    result = (List<Game>)(from game in games
                                          orderby game.dateAdded descending
                                          select game).Take(10).ToList();
                    break;
            }
            return PartialView(result);
          
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}