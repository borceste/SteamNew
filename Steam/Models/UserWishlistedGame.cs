using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Steam.Models
{
    public class UserWishlistedGame
    {
       
        public int GameId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
      
        public string UserId { get; set; }
        public UserWishlistedGame()
        {

        }
    }
}