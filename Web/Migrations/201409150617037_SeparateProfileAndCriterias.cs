namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeparateProfileAndCriterias : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProfileFirstLevelCriteria", "ProfileId", "dbo.Profile");
            DropForeignKey("dbo.ProfileFirstLevelCriteria", "FirstLevelCriteriaId", "dbo.FirstLevelCriterias");
            DropForeignKey("dbo.ProfileSecondLevelCriteria", "ProfileId", "dbo.Profile");
            DropForeignKey("dbo.ProfileSecondLevelCriteria", "SecondLevelCriteriaId", "dbo.SecondLevelCriterias");
            DropForeignKey("dbo.ProfileThirdLevelCriteria", "ProfileId", "dbo.Profile");
            DropForeignKey("dbo.ProfileThirdLevelCriteria", "ThirdLevelCriteriaId", "dbo.ThirdLevelCriterias");
            DropIndex("dbo.ProfileFirstLevelCriteria", new[] { "ProfileId" });
            DropIndex("dbo.ProfileFirstLevelCriteria", new[] { "FirstLevelCriteriaId" });
            DropIndex("dbo.ProfileSecondLevelCriteria", new[] { "ProfileId" });
            DropIndex("dbo.ProfileSecondLevelCriteria", new[] { "SecondLevelCriteriaId" });
            DropIndex("dbo.ProfileThirdLevelCriteria", new[] { "ProfileId" });
            DropIndex("dbo.ProfileThirdLevelCriteria", new[] { "ThirdLevelCriteriaId" });
            CreateTable(
                "dbo.Profile1LevelCriteria",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        CriteriaId = c.Guid(nullable: false),
                        ProfileId = c.Long(nullable: false),
                        Profile_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FirstLevelCriterias", t => t.CriteriaId, cascadeDelete: true)
                .ForeignKey("dbo.Profile", t => t.Profile_Id)
                .Index(t => t.CriteriaId)
                .Index(t => t.Profile_Id);
            
            CreateTable(
                "dbo.Profile2LevelCriteria",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        CriteriaId = c.Guid(nullable: false),
                        ProfileId = c.Long(nullable: false),
                        Profile_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SecondLevelCriterias", t => t.CriteriaId, cascadeDelete: true)
                .ForeignKey("dbo.Profile", t => t.Profile_Id)
                .Index(t => t.CriteriaId)
                .Index(t => t.Profile_Id);
            
            CreateTable(
                "dbo.Profile3LevelCriteria",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        CriteriaId = c.Guid(nullable: false),
                        ProfileId = c.Long(nullable: false),
                        Profile_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ThirdLevelCriterias", t => t.CriteriaId, cascadeDelete: true)
                .ForeignKey("dbo.Profile", t => t.Profile_Id)
                .Index(t => t.CriteriaId)
                .Index(t => t.Profile_Id);
            
            DropTable("dbo.ProfileFirstLevelCriteria");
            DropTable("dbo.ProfileSecondLevelCriteria");
            DropTable("dbo.ProfileThirdLevelCriteria");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ProfileThirdLevelCriteria",
                c => new
                    {
                        ProfileId = c.String(nullable: false, maxLength: 128),
                        ThirdLevelCriteriaId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProfileId, t.ThirdLevelCriteriaId });
            
            CreateTable(
                "dbo.ProfileSecondLevelCriteria",
                c => new
                    {
                        ProfileId = c.String(nullable: false, maxLength: 128),
                        SecondLevelCriteriaId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProfileId, t.SecondLevelCriteriaId });
            
            CreateTable(
                "dbo.ProfileFirstLevelCriteria",
                c => new
                    {
                        ProfileId = c.String(nullable: false, maxLength: 128),
                        FirstLevelCriteriaId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProfileId, t.FirstLevelCriteriaId });
            
            DropForeignKey("dbo.Profile3LevelCriteria", "Profile_Id", "dbo.Profile");
            DropForeignKey("dbo.Profile3LevelCriteria", "CriteriaId", "dbo.ThirdLevelCriterias");
            DropForeignKey("dbo.Profile2LevelCriteria", "Profile_Id", "dbo.Profile");
            DropForeignKey("dbo.Profile2LevelCriteria", "CriteriaId", "dbo.SecondLevelCriterias");
            DropForeignKey("dbo.Profile1LevelCriteria", "Profile_Id", "dbo.Profile");
            DropForeignKey("dbo.Profile1LevelCriteria", "CriteriaId", "dbo.FirstLevelCriterias");
            DropIndex("dbo.Profile3LevelCriteria", new[] { "Profile_Id" });
            DropIndex("dbo.Profile3LevelCriteria", new[] { "CriteriaId" });
            DropIndex("dbo.Profile2LevelCriteria", new[] { "Profile_Id" });
            DropIndex("dbo.Profile2LevelCriteria", new[] { "CriteriaId" });
            DropIndex("dbo.Profile1LevelCriteria", new[] { "Profile_Id" });
            DropIndex("dbo.Profile1LevelCriteria", new[] { "CriteriaId" });
            DropTable("dbo.Profile3LevelCriteria");
            DropTable("dbo.Profile2LevelCriteria");
            DropTable("dbo.Profile1LevelCriteria");
            CreateIndex("dbo.ProfileThirdLevelCriteria", "ThirdLevelCriteriaId");
            CreateIndex("dbo.ProfileThirdLevelCriteria", "ProfileId");
            CreateIndex("dbo.ProfileSecondLevelCriteria", "SecondLevelCriteriaId");
            CreateIndex("dbo.ProfileSecondLevelCriteria", "ProfileId");
            CreateIndex("dbo.ProfileFirstLevelCriteria", "FirstLevelCriteriaId");
            CreateIndex("dbo.ProfileFirstLevelCriteria", "ProfileId");
            AddForeignKey("dbo.ProfileThirdLevelCriteria", "ThirdLevelCriteriaId", "dbo.ThirdLevelCriterias", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProfileThirdLevelCriteria", "ProfileId", "dbo.Profile", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProfileSecondLevelCriteria", "SecondLevelCriteriaId", "dbo.SecondLevelCriterias", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProfileSecondLevelCriteria", "ProfileId", "dbo.Profile", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProfileFirstLevelCriteria", "FirstLevelCriteriaId", "dbo.FirstLevelCriterias", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProfileFirstLevelCriteria", "ProfileId", "dbo.Profile", "Id", cascadeDelete: true);
        }
    }
}
