namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriteriasAndCourseraCategory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CriteriaWithCourseraCategories",
                c => new
                    {
                        GlobalCriteriaId = c.Guid(nullable: false),
                        GlobalCriteriaName = c.String(),
                        CourseraCategoryName = c.String(),
                    })
                .PrimaryKey(t => t.GlobalCriteriaId);
            
            AddColumn("dbo.Categories", "CriteriaWithCourseraCategory_GlobalCriteriaId", c => c.Guid());
            CreateIndex("dbo.Categories", "CriteriaWithCourseraCategory_GlobalCriteriaId");
            AddForeignKey("dbo.Categories", "CriteriaWithCourseraCategory_GlobalCriteriaId", "dbo.CriteriaWithCourseraCategories", "GlobalCriteriaId");
            DropTable("dbo.CriteriaForCourseras");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.CriteriaForCourseras",
                c => new
                    {
                        CriteriaForCourseraId = c.Int(nullable: false, identity: true),
                        CourseraCategoryId = c.Int(nullable: false),
                        FirstLevelCriteriaId = c.Int(nullable: false),
                        SecondLevelCriteriaId = c.Int(nullable: false),
                        ThirdLevelCriteriaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CriteriaForCourseraId);
            
            DropForeignKey("dbo.Categories", "CriteriaWithCourseraCategory_GlobalCriteriaId", "dbo.CriteriaWithCourseraCategories");
            DropIndex("dbo.Categories", new[] { "CriteriaWithCourseraCategory_GlobalCriteriaId" });
            DropColumn("dbo.Categories", "CriteriaWithCourseraCategory_GlobalCriteriaId");
            DropTable("dbo.CriteriaWithCourseraCategories");
        }
    }
}
