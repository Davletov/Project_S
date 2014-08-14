namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BindProfileWithCriterias : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProfileFirstLevelCriteria",
                c => new
                    {
                        ProfileId = c.String(nullable: false, maxLength: 128),
                        FirstLevelCriteriaId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProfileId, t.FirstLevelCriteriaId })
                .ForeignKey("dbo.Profile", t => t.ProfileId, cascadeDelete: true)
                .ForeignKey("dbo.FirstLevelCriterias", t => t.FirstLevelCriteriaId, cascadeDelete: true)
                .Index(t => t.ProfileId)
                .Index(t => t.FirstLevelCriteriaId);
            
            CreateTable(
                "dbo.ProfileSecondLevelCriteria",
                c => new
                    {
                        ProfileId = c.String(nullable: false, maxLength: 128),
                        SecondLevelCriteriaId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProfileId, t.SecondLevelCriteriaId })
                .ForeignKey("dbo.Profile", t => t.ProfileId, cascadeDelete: true)
                .ForeignKey("dbo.SecondLevelCriterias", t => t.SecondLevelCriteriaId, cascadeDelete: true)
                .Index(t => t.ProfileId)
                .Index(t => t.SecondLevelCriteriaId);
            
            CreateTable(
                "dbo.ProfileThirdLevelCriteria",
                c => new
                    {
                        ProfileId = c.String(nullable: false, maxLength: 128),
                        ThirdLevelCriteriaId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProfileId, t.ThirdLevelCriteriaId })
                .ForeignKey("dbo.Profile", t => t.ProfileId, cascadeDelete: true)
                .ForeignKey("dbo.ThirdLevelCriterias", t => t.ThirdLevelCriteriaId, cascadeDelete: true)
                .Index(t => t.ProfileId)
                .Index(t => t.ThirdLevelCriteriaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProfileThirdLevelCriteria", "ThirdLevelCriteriaId", "dbo.ThirdLevelCriterias");
            DropForeignKey("dbo.ProfileThirdLevelCriteria", "ProfileId", "dbo.Profile");
            DropForeignKey("dbo.ProfileSecondLevelCriteria", "SecondLevelCriteriaId", "dbo.SecondLevelCriterias");
            DropForeignKey("dbo.ProfileSecondLevelCriteria", "ProfileId", "dbo.Profile");
            DropForeignKey("dbo.ProfileFirstLevelCriteria", "FirstLevelCriteriaId", "dbo.FirstLevelCriterias");
            DropForeignKey("dbo.ProfileFirstLevelCriteria", "ProfileId", "dbo.Profile");
            DropIndex("dbo.ProfileThirdLevelCriteria", new[] { "ThirdLevelCriteriaId" });
            DropIndex("dbo.ProfileThirdLevelCriteria", new[] { "ProfileId" });
            DropIndex("dbo.ProfileSecondLevelCriteria", new[] { "SecondLevelCriteriaId" });
            DropIndex("dbo.ProfileSecondLevelCriteria", new[] { "ProfileId" });
            DropIndex("dbo.ProfileFirstLevelCriteria", new[] { "FirstLevelCriteriaId" });
            DropIndex("dbo.ProfileFirstLevelCriteria", new[] { "ProfileId" });
            DropTable("dbo.ProfileThirdLevelCriteria");
            DropTable("dbo.ProfileSecondLevelCriteria");
            DropTable("dbo.ProfileFirstLevelCriteria");
        }
    }
}
