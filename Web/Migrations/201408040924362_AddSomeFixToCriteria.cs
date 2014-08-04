namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSomeFixToCriteria : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FirstLevelCriterias", "ThirdLevelCriteriaId", "dbo.ThirdLevelCriterias");
            DropIndex("dbo.FirstLevelCriterias", new[] { "ThirdLevelCriteriaId" });
            AddColumn("dbo.SecondLevelCriterias", "ThirdLevelCriteriaId", c => c.Int(nullable: false));
            CreateIndex("dbo.SecondLevelCriterias", "ThirdLevelCriteriaId");
            AddForeignKey("dbo.SecondLevelCriterias", "ThirdLevelCriteriaId", "dbo.ThirdLevelCriterias", "ThirdLevelCriteriaId", cascadeDelete: true);
            DropColumn("dbo.FirstLevelCriterias", "ThirdLevelCriteriaId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FirstLevelCriterias", "ThirdLevelCriteriaId", c => c.Int(nullable: false));
            DropForeignKey("dbo.SecondLevelCriterias", "ThirdLevelCriteriaId", "dbo.ThirdLevelCriterias");
            DropIndex("dbo.SecondLevelCriterias", new[] { "ThirdLevelCriteriaId" });
            DropColumn("dbo.SecondLevelCriterias", "ThirdLevelCriteriaId");
            CreateIndex("dbo.FirstLevelCriterias", "ThirdLevelCriteriaId");
            AddForeignKey("dbo.FirstLevelCriterias", "ThirdLevelCriteriaId", "dbo.ThirdLevelCriterias", "ThirdLevelCriteriaId", cascadeDelete: true);
        }
    }
}
