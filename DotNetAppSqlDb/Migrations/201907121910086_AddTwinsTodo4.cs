namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTwinsTodo4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KidsTodoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpBy550 = c.Boolean(nullable: false),
                        GodSpokeToMyHeart = c.Boolean(nullable: false),
                        JohnWentRun = c.Boolean(nullable: false),
                        JamesWentRun = c.Boolean(nullable: false),
                        PhilipWentRun = c.Boolean(nullable: false),
                        PhilipDidWeights = c.Boolean(nullable: false),
                        PhilipDid100WordsInMorning = c.Boolean(nullable: false),
                        PhilipDid1000Words = c.Boolean(nullable: false),
                        TwinsFightSchool = c.Boolean(nullable: false),
                        James100WordsStudy = c.Boolean(nullable: false),
                        John100WordsStudy = c.Boolean(nullable: false),
                        James5SkillsIXL = c.Boolean(nullable: false),
                        Hannah10SkillsIXL = c.Boolean(nullable: false),
                        HannahPiano = c.Boolean(nullable: false),
                        JamesRecord1PiecePiano = c.Boolean(nullable: false),
                        JohnRecord1PiecePiano = c.Boolean(nullable: false),
                        JamesRecordPianoScale130 = c.Boolean(nullable: false),
                        JohnRecordPianoScale130 = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.KidsTodoes");
        }
    }
}
