namespace Steam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Games", "ApplicationUserOwned_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Games", "ApplicationUserWish_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Games", new[] { "ApplicationUserOwned_Id" });
            DropIndex("dbo.Games", new[] { "ApplicationUserWish_Id" });
            AddColumn("dbo.AspNetUsers", "Game_GameId", c => c.Int());
            AddColumn("dbo.AspNetUsers", "Game_GameId1", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "Game_GameId");
            CreateIndex("dbo.AspNetUsers", "Game_GameId1");
            AddForeignKey("dbo.AspNetUsers", "Game_GameId", "dbo.Games", "GameId");
            AddForeignKey("dbo.AspNetUsers", "Game_GameId1", "dbo.Games", "GameId");
            DropColumn("dbo.Games", "ApplicationUserOwned_Id");
            DropColumn("dbo.Games", "ApplicationUserWish_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Games", "ApplicationUserWish_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Games", "ApplicationUserOwned_Id", c => c.String(maxLength: 128));
            DropForeignKey("dbo.AspNetUsers", "Game_GameId1", "dbo.Games");
            DropForeignKey("dbo.AspNetUsers", "Game_GameId", "dbo.Games");
            DropIndex("dbo.AspNetUsers", new[] { "Game_GameId1" });
            DropIndex("dbo.AspNetUsers", new[] { "Game_GameId" });
            DropColumn("dbo.AspNetUsers", "Game_GameId1");
            DropColumn("dbo.AspNetUsers", "Game_GameId");
            CreateIndex("dbo.Games", "ApplicationUserWish_Id");
            CreateIndex("dbo.Games", "ApplicationUserOwned_Id");
            AddForeignKey("dbo.Games", "ApplicationUserWish_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Games", "ApplicationUserOwned_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
