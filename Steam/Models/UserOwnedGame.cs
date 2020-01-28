using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Steam.Models
{
    public class UserOwnedGame
    {
        
        public int GameId { get; set; }

       
        public string UserId { get; set; }
        public UserOwnedGame()
        {

        }
    }
}