using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Steam.Models
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }
        public String name { set; get; }
        public virtual ICollection<Game> Games { get; set; }
       
        public Genre()
        {
            Games = new HashSet<Game>();
        }
        public Genre(String name)
        {
            this.name = name;
        }
        /*public String getName()
        {
            return this.name;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public List<Game> getGames()
        {
            return this.games;
        }
        public void setGames(List<Game> games)
        {
            if (this.games.Count == 0)
            {
                this.games = games;
            }
            else
            {
                foreach(Game g in games)
                {
                    this.games.Add(g);
                }
            }
        }
        public void addGame(Game game)
        {
            if (!this.games.Contains(game))
            {
                this.games.Add(game);
            }
        }*/
    }
}