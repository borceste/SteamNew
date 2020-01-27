using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Steam.Models
{
	// You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
	public class ApplicationUser : IdentityUser
	{
        public String nickname { get; set; }
        public string avatar { get; set; }
        public String info { get; set; }
        public int level { get; set; }

        public ApplicationUser() {
			this.Comments = new HashSet<Comment>();
			this.Reviews = new HashSet<Review>();
			this.ownedGames = new HashSet<Game>();
			this.wishlistedGames = new HashSet<Game>();

			this.nickname = "";
			this.avatar = "";
			this.info = "";
			this.level = 0;
				 
		
		}
        public ApplicationUser(string id, string nickname, string avatar, string info, int level, string email, Boolean emailConfirmed, Boolean phoneNumberConfirmed , Boolean twoFactorEnabled, Boolean lockOutEnabled, int accessFailedCount,string password, string username) {
            this.Id = id;
            this.nickname = nickname;
            this.avatar = avatar;
            this.info = info;
            this.level = level;
            this.Email = email;
            this.PasswordHash = password;
            this.PhoneNumberConfirmed = phoneNumberConfirmed;
            this.TwoFactorEnabled = twoFactorEnabled;
            this.LockoutEnabled = lockOutEnabled;
            this.AccessFailedCount = accessFailedCount;
            this.UserName = username;
        
        }


		

		public virtual ICollection<Comment> Comments { get; set; }

		public virtual ICollection<Review> Reviews { get; set; }
		public virtual ICollection<Game> ownedGames { get; set; }
		public virtual ICollection<Game> wishlistedGames { get; set; }

		public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
		{
			// Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
			var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
			// Add custom user claims here
			return userIdentity;
		}
	}

	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{



		public DbSet<Game> Games { get; set; }
		public DbSet<Review> Reviews { get; set; }
		
		public DbSet<Genre> Genres { get; set; }
		public DbSet<Comment> Comments { get; set; }
        public DbSet<GameImage> GameImages { get; set; }

        public ApplicationDbContext()
			: base("DefaultConnection", throwIfV1Schema: false)
		{
		   //AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Directory.GetCurrentDirectory());
		}

		public static ApplicationDbContext Create()
		{
			return new ApplicationDbContext();
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{

            modelBuilder.Entity<Game>()
                .HasMany(c => c.ApplicationUsersOwned)
                .WithMany(c => c.ownedGames)
                .Map(ow =>
                {
                    ow.ToTable("UserOwnedGames");
                    ow.MapLeftKey("GameId");
                    ow.MapRightKey("UserId");
                });

            modelBuilder.Entity<Game>()
                .HasMany(c => c.ApplicationUsersWish)
                .WithMany(c => c.wishlistedGames)
                .Map(m =>
                {
                    m.ToTable("UserWishlistedGames");
                    m.MapLeftKey("GameId");
                    m.MapRightKey("UserId");
                });

            base.OnModelCreating(modelBuilder);
		}

       
    }
}