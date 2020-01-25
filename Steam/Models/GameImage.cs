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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GameImageId { get; set; }

        public Nullable<int> GameId { get; set; }

        public virtual Game Game { get; set; }

        public String UrlString { get; set; }

         public GameImage(String Url)
        {
            this.UrlString = Url;
        }

        public GameImage(int GameId, string Url)
        {
            this.GameId = GameId;
            this.UrlString = Url;
        }


    }
}