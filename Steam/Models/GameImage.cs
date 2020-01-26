using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Steam.Models
{
    public class GameImage
    {
        [Key]
       
        public int GameImageId { get; set; }

        public Nullable<int> GameId { get; set; }
        public virtual Game Game { get; set; }

        public String UrlString { get; set; }

       
        public GameImage(int gameId, string Url)
        {
            this.GameId = gameId; 
            this.UrlString = Url;
        }

        public GameImage() {
            
        
        }




    }
}