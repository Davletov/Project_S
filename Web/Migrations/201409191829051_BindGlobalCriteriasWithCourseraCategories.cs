namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BindGlobalCriteriasWithCourseraCategories : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.SecondLevelCriterias", new[] { "FirstLevelCriteria_Id" });
            DropIndex("dbo.SecondLevelCriterias", new[] { "FirstLevelCriteria_Id1" });
            RenameColumn(table: "dbo.SecondLevelCriterias", name: "FirstLevelCriteria_Id1", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.SecondLevelCriterias", name: "FirstLevelCriteria_Id", newName: "FirstLevelCriteria_Id1");
            RenameColumn(table: "dbo.SecondLevelCriterias", name: "__mig_tmp__0", newName: "FirstLevelCriteria_Id");
            CreateTable(
                "dbo.CourseWithSecondLevel",
                c => new
                    {
                        CourseId = c.Int(nullable: false),
                        SecondLevelId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.CourseId, t.SecondLevelId })
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.SecondLevelCriterias", t => t.SecondLevelId, cascadeDelete: true)
                .Index(t => t.CourseId)
                .Index(t => t.SecondLevelId);
            
            CreateTable(
                "dbo.CourseWithThirdLevel",
                c => new
                    {
                        CourseId = c.Int(nullable: false),
                        ThirdLevelId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.CourseId, t.ThirdLevelId })
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.ThirdLevelCriterias", t => t.ThirdLevelId, cascadeDelete: true)
                .Index(t => t.CourseId)
                .Index(t => t.ThirdLevelId);
            
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
            
            AlterColumn("dbo.SecondLevelCriterias", "FirstLevelCriteria_Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.SecondLevelCriterias", "FirstLevelCriteria_Id1", c => c.Guid());
            CreateIndex("dbo.SecondLevelCriterias", "FirstLevelCriteria_Id");
            CreateIndex("dbo.SecondLevelCriterias", "FirstLevelCriteria_Id1");
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
            DropForeignKey("dbo.CourseWithThirdLevel", "ThirdLevelId", "dbo.ThirdLevelCriterias");
            DropForeignKey("dbo.CourseWithThirdLevel", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.CourseWithSecondLevel", "SecondLevelId", "dbo.SecondLevelCriterias");
            DropForeignKey("dbo.CourseWithSecondLevel", "CourseId", "dbo.Courses");
            DropIndex("dbo.CategoryWithThirdLevel", new[] { "ThirdLevelId" });
            DropIndex("dbo.CategoryWithThirdLevel", new[] { "CategoryId" });
            DropIndex("dbo.CategoryWithSecondLevel", new[] { "SecondLevelId" });
            DropIndex("dbo.CategoryWithSecondLevel", new[] { "CategoryId" });
            DropIndex("dbo.CategoryWithFirstLevel", new[] { "FirstLevelId" });
            DropIndex("dbo.CategoryWithFirstLevel", new[] { "CategoryId" });
            DropIndex("dbo.CourseWithThirdLevel", new[] { "ThirdLevelId" });
            DropIndex("dbo.CourseWithThirdLevel", new[] { "CourseId" });
            DropIndex("dbo.CourseWithSecondLevel", new[] { "SecondLevelId" });
            DropIndex("dbo.CourseWithSecondLevel", new[] { "CourseId" });
            DropIndex("dbo.SecondLevelCriterias", new[] { "FirstLevelCriteria_Id1" });
            DropIndex("dbo.SecondLevelCriterias", new[] { "FirstLevelCriteria_Id" });
            AlterColumn("dbo.SecondLevelCriterias", "FirstLevelCriteria_Id1", c => c.Guid(nullable: false));
            AlterColumn("dbo.SecondLevelCriterias", "FirstLevelCriteria_Id", c => c.Guid());
            DropTable("dbo.CategoryWithThirdLevel");
            DropTable("dbo.CategoryWithSecondLevel");
            DropTable("dbo.CategoryWithFirstLevel");
            DropTable("dbo.CourseWithThirdLevel");
            DropTable("dbo.CourseWithSecondLevel");
            RenameColumn(table: "dbo.SecondLevelCriterias", name: "FirstLevelCriteria_Id", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.SecondLevelCriterias", name: "FirstLevelCriteria_Id1", newName: "FirstLevelCriteria_Id");
            RenameColumn(table: "dbo.SecondLevelCriterias", name: "__mig_tmp__0", newName: "FirstLevelCriteria_Id1");
            CreateIndex("dbo.SecondLevelCriterias", "FirstLevelCriteria_Id1");
            CreateIndex("dbo.SecondLevelCriterias", "FirstLevelCriteria_Id");
        }
    }
}
