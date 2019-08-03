namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatecategorynamefield : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Todoes", "CategoryName", c => c.String());
            DropColumn("dbo.Todoes", "SuccessOrFailureCategory");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Todoes", "SuccessOrFailureCategory", c => c.String());
            DropColumn("dbo.Todoes", "CategoryName");
        }
    }
}
