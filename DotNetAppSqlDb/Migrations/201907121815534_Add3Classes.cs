namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add3Classes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        TaskID = c.Int(nullable: false, identity: true),
                        TaskDescription = c.String(maxLength: 50),
                        Done = c.Boolean(),
                        DateStarted = c.DateTime(),
                        DateCompleted = c.DateTime(),
                        Category = c.Int(),
                        UserID = c.Int(),
                        Deadline = c.DateTime(),
                    })
                .PrimaryKey(t => t.TaskID)
                .ForeignKey("dbo.Users", t => t.UserID)
                .ForeignKey("dbo.Categories", t => t.Category)
                .Index(t => t.Category)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "Category", "dbo.Categories");
            DropForeignKey("dbo.Tasks", "UserID", "dbo.Users");
            DropIndex("dbo.Tasks", new[] { "UserID" });
            DropIndex("dbo.Tasks", new[] { "Category" });
            DropTable("dbo.Users");
            DropTable("dbo.Tasks");
            DropTable("dbo.Categories");
        }
    }
}
