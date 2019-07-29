namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HolidayTaskListAdded2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HolidayTasks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UpBy815 = c.Boolean(nullable: false),
                        EntryDate = c.DateTime(nullable: false),
                        PhilipWordQuantity = c.Int(nullable: false),
                        JamesWordQuantity = c.Int(nullable: false),
                        JohnWordQuantity = c.Int(nullable: false),
                        PhilipLastRunDate = c.DateTime(nullable: false),
                        PhilipLastWeightsDate = c.DateTime(nullable: false),
                        PhilipLastCycleDate = c.DateTime(nullable: false),
                        UserID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.UserID)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HolidayTasks", "UserID", "dbo.Users");
            DropIndex("dbo.HolidayTasks", new[] { "UserID" });
            DropTable("dbo.HolidayTasks");
        }
    }
}
