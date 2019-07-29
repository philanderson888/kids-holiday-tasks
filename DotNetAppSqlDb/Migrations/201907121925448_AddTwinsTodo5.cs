namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTwinsTodo5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.KidsTodoes", "UserID", c => c.Int());
            CreateIndex("dbo.KidsTodoes", "UserID");
            AddForeignKey("dbo.KidsTodoes", "UserID", "dbo.Users", "UserID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.KidsTodoes", "UserID", "dbo.Users");
            DropIndex("dbo.KidsTodoes", new[] { "UserID" });
            DropColumn("dbo.KidsTodoes", "UserID");
        }
    }
}
