namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BindGlobalCriteriasWithCourseraCategories : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CategoryWithFirstLevel",
                c => new
                    {
                        CategoryId = c.Int(nullable: false),
                        FirstLevelId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.CategoryId, t.FirstLevelId })
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.FirstLevelCriterias", t => t.FirstLevelId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.FirstLevelId);
            
            CreateTable(
                "dbo.CategoryWithSecondLevel",
                c => new
                    {
                        CategoryId = c.Int(nullable: false),
                        SecondLevelId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.CategoryId, t.SecondLevelId })
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.SecondLevelCriterias", t => t.SecondLevelId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.SecondLevelId);
            
            CreateTable(
                "dbo.CategoryWithThirdLevel",
                c => new
                    {
                        CategoryId = c.Int(nullable: false),
                        ThirdLevelId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.CategoryId, t.ThirdLevelId })
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.ThirdLevelCriterias", t => t.ThirdLevelId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.ThirdLevelId);
            
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
            
            DropForeignKey("dbo.CategoryWithThirdLevel", "ThirdLevelId", "dbo.ThirdLevelCriterias");
            DropForeignKey("dbo.CategoryWithThirdLevel", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.CategoryWithSecondLevel", "SecondLevelId", "dbo.SecondLevelCriterias");
            DropForeignKey("dbo.CategoryWithSecondLevel", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.CategoryWithFirstLevel", "FirstLevelId", "dbo.FirstLevelCriterias");
            DropForeignKey("dbo.CategoryWithFirstLevel", "CategoryId", "dbo.Categories");
            DropIndex("dbo.CategoryWithThirdLevel", new[] { "ThirdLevelId" });
            DropIndex("dbo.CategoryWithThirdLevel", new[] { "CategoryId" });
            DropIndex("dbo.CategoryWithSecondLevel", new[] { "SecondLevelId" });
            DropIndex("dbo.CategoryWithSecondLevel", new[] { "CategoryId" });
            DropIndex("dbo.CategoryWithFirstLevel", new[] { "FirstLevelId" });
            DropIndex("dbo.CategoryWithFirstLevel", new[] { "CategoryId" });
            DropTable("dbo.CategoryWithThirdLevel");
            DropTable("dbo.CategoryWithSecondLevel");
            DropTable("dbo.CategoryWithFirstLevel");
        }
    }
}
