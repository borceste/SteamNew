namespace Steam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reviews", "Game_GameId1", "dbo.Games");
            DropIndex("dbo.Reviews", new[] { "Game_GameId1" });
            DropIndex("dbo.Reviews", new[] { "Game_GameId2" });
            DropColumn("dbo.Reviews", "GameId");
            DropColumn("dbo.Reviews", "GameId");
            RenameColumn(table: "dbo.GameImages", name: "Game_GameId", newName: "GameId");
            RenameColumn(table: "dbo.Reviews", name: "Game_GameId2", newName: "GameId");
            RenameColumn(table: "dbo.Reviews", name: "Game_GameId", newName: "GameId");
            RenameIndex(table: "dbo.GameImages", name: "IX_Game_GameId", newName: "IX_GameId");
            RenameIndex(table: "dbo.Reviews", name: "IX_Game_GameId", newName: "IX_GameId");
            DropColumn("dbo.Reviews", "Game_GameId1");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reviews", "Game_GameId1", c => c.Int());
            RenameIndex(table: "dbo.Reviews", name: "IX_GameId", newName: "IX_Game_GameId");
            RenameIndex(table: "dbo.GameImages", name: "IX_GameId", newName: "IX_Game_GameId");
            RenameColumn(table: "dbo.Reviews", name: "GameId", newName: "Game_GameId");
            RenameColumn(table: "dbo.Reviews", name: "GameId", newName: "Game_GameId2");
            RenameColumn(table: "dbo.GameImages", name: "GameId", newName: "Game_GameId");
            AddColumn("dbo.Reviews", "GameId", c => c.Int());
            AddColumn("dbo.Reviews", "GameId", c => c.Int());
            CreateIndex("dbo.Reviews", "Game_GameId2");
            CreateIndex("dbo.Reviews", "Game_GameId1");
            AddForeignKey("dbo.Reviews", "Game_GameId1", "dbo.Games", "GameId");
        }
    }
}
