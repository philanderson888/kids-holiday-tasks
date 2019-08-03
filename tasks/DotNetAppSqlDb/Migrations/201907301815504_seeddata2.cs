namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seeddata2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Todoes", "Done");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Todoes", "Done", c => c.Boolean(nullable: false));
        }
    }
}
