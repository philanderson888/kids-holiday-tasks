namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDone2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Todoes", "Done2", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Todoes", "Done2");
        }
    }
}
