namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class qualificationstudentaddboth : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Qualifications",
                c => new
                    {
                        QualificationId = c.Int(nullable: false, identity: true),
                        QualificationName = c.String(),
                        Section = c.String(),
                    })
                .PrimaryKey(t => t.QualificationId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        StudentName = c.String(),
                        DateOfBirth = c.DateTime(),
                        Photo = c.Binary(),
                        Height = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Single(nullable: false),
                        Qualification_QualificationId = c.Int(),
                    })
                .PrimaryKey(t => t.StudentID)
                .ForeignKey("dbo.Qualifications", t => t.Qualification_QualificationId)
                .Index(t => t.Qualification_QualificationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Qualification_QualificationId", "dbo.Qualifications");
            DropIndex("dbo.Students", new[] { "Qualification_QualificationId" });
            DropTable("dbo.Students");
            DropTable("dbo.Qualifications");
        }
    }
}
