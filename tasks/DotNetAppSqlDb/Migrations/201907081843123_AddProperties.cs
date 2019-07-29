namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProperties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Todoes", "UpEarly", c => c.Boolean(nullable: false));
            AddColumn("dbo.Todoes", "StayUp", c => c.Boolean(nullable: false));
            AddColumn("dbo.Todoes", "MakeGym", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Todoes", "MakeGym");
            DropColumn("dbo.Todoes", "StayUp");
            DropColumn("dbo.Todoes", "UpEarly");
        }
    }
}
