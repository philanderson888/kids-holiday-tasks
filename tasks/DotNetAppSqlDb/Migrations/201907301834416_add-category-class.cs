namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcategoryclass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            AddColumn("dbo.Todoes", "SuccessOrFailureCategory", c => c.String());
            AddColumn("dbo.Todoes", "Category1_CategoryId", c => c.Int());
            CreateIndex("dbo.Todoes", "Category1_CategoryId");
            AddForeignKey("dbo.Todoes", "Category1_CategoryId", "dbo.Categories", "CategoryId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Todoes", "Category1_CategoryId", "dbo.Categories");
            DropIndex("dbo.Todoes", new[] { "Category1_CategoryId" });
            DropColumn("dbo.Todoes", "Category1_CategoryId");
            DropColumn("dbo.Todoes", "SuccessOrFailureCategory");
            DropTable("dbo.Categories");
        }
    }
}
