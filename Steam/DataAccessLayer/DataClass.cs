using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Steam.Models;

namespace Steam.DataAccessLayer
{
    public class DataClass : DbContext
    {
        public DataClass() : base("DataClass")
        {


        }
        public DbSet<Game> Games { get; set; }
        public DbSet<GameImage> GameImages {get;set;}
        public DbSet<User> Users { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Comment> Comments { get; set; }

        
    }
}