namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddToDo2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Todo2",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        Done = c.Boolean(nullable: false),
                        Done2 = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Todo2");
        }
    }
}
