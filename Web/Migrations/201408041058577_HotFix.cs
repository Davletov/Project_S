namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HotFix : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FirstLevelCriterias", "SecondLevelCriteriaId", "dbo.SecondLevelCriterias");
            DropForeignKey("dbo.SecondLevelCriterias", "ThirdLevelCriteriaId", "dbo.ThirdLevelCriterias");
            DropIndex("dbo.FirstLevelCriterias", new[] { "SecondLevelCriteriaId" });
            DropIndex("dbo.SecondLevelCriterias", new[] { "ThirdLevelCriteriaId" });
            AddColumn("dbo.SecondLevelCriterias", "FirstLevelCriteria_FirstLevelCriteriaId", c => c.Int());
            AddColumn("dbo.SecondLevelCriterias", "FirstLevelCriteria_FirstLevelCriteriaId1", c => c.Int(nullable: false));
            AddColumn("dbo.ThirdLevelCriterias", "SecondLevelCriteria_SecondLevelCriteriaId", c => c.Int());
            AddColumn("dbo.ThirdLevelCriterias", "SecondLevelCriteria_SecondLevelCriteriaId1", c => c.Int(nullable: false));
            CreateIndex("dbo.SecondLevelCriterias", "FirstLevelCriteria_FirstLevelCriteriaId");
            CreateIndex("dbo.SecondLevelCriterias", "FirstLevelCriteria_FirstLevelCriteriaId1");
            CreateIndex("dbo.ThirdLevelCriterias", "SecondLevelCriteria_SecondLevelCriteriaId");
            CreateIndex("dbo.ThirdLevelCriterias", "SecondLevelCriteria_SecondLevelCriteriaId1");
            AddForeignKey("dbo.SecondLevelCriterias", "FirstLevelCriteria_FirstLevelCriteriaId", "dbo.FirstLevelCriterias", "FirstLevelCriteriaId");
            AddForeignKey("dbo.ThirdLevelCriterias", "SecondLevelCriteria_SecondLevelCriteriaId", "dbo.SecondLevelCriterias", "SecondLevelCriteriaId");
            AddForeignKey("dbo.SecondLevelCriterias", "FirstLevelCriteria_FirstLevelCriteriaId1", "dbo.FirstLevelCriterias", "FirstLevelCriteriaId", cascadeDelete: true);
            AddForeignKey("dbo.ThirdLevelCriterias", "SecondLevelCriteria_SecondLevelCriteriaId1", "dbo.SecondLevelCriterias", "SecondLevelCriteriaId", cascadeDelete: true);
            DropColumn("dbo.FirstLevelCriterias", "SecondLevelCriteriaId");
            DropColumn("dbo.SecondLevelCriterias", "ThirdLevelCriteriaId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SecondLevelCriterias", "ThirdLevelCriteriaId", c => c.Int(nullable: false));
            AddColumn("dbo.FirstLevelCriterias", "SecondLevelCriteriaId", c => c.Int(nullable: false));
            DropForeignKey("dbo.ThirdLevelCriterias", "SecondLevelCriteria_SecondLevelCriteriaId1", "dbo.SecondLevelCriterias");
            DropForeignKey("dbo.SecondLevelCriterias", "FirstLevelCriteria_FirstLevelCriteriaId1", "dbo.FirstLevelCriterias");
            DropForeignKey("dbo.ThirdLevelCriterias", "SecondLevelCriteria_SecondLevelCriteriaId", "dbo.SecondLevelCriterias");
            DropForeignKey("dbo.SecondLevelCriterias", "FirstLevelCriteria_FirstLevelCriteriaId", "dbo.FirstLevelCriterias");
            DropIndex("dbo.ThirdLevelCriterias", new[] { "SecondLevelCriteria_SecondLevelCriteriaId1" });
            DropIndex("dbo.ThirdLevelCriterias", new[] { "SecondLevelCriteria_SecondLevelCriteriaId" });
            DropIndex("dbo.SecondLevelCriterias", new[] { "FirstLevelCriteria_FirstLevelCriteriaId1" });
            DropIndex("dbo.SecondLevelCriterias", new[] { "FirstLevelCriteria_FirstLevelCriteriaId" });
            DropColumn("dbo.ThirdLevelCriterias", "SecondLevelCriteria_SecondLevelCriteriaId1");
            DropColumn("dbo.ThirdLevelCriterias", "SecondLevelCriteria_SecondLevelCriteriaId");
            DropColumn("dbo.SecondLevelCriterias", "FirstLevelCriteria_FirstLevelCriteriaId1");
            DropColumn("dbo.SecondLevelCriterias", "FirstLevelCriteria_FirstLevelCriteriaId");
            CreateIndex("dbo.SecondLevelCriterias", "ThirdLevelCriteriaId");
            CreateIndex("dbo.FirstLevelCriterias", "SecondLevelCriteriaId");
            AddForeignKey("dbo.SecondLevelCriterias", "ThirdLevelCriteriaId", "dbo.ThirdLevelCriterias", "ThirdLevelCriteriaId", cascadeDelete: true);
            AddForeignKey("dbo.FirstLevelCriterias", "SecondLevelCriteriaId", "dbo.SecondLevelCriterias", "SecondLevelCriteriaId", cascadeDelete: true);
        }
    }
}
