namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BindCoursesWithGlobalCriterias : DbMigration
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
            
            AlterColumn("dbo.SecondLevelCriterias", "FirstLevelCriteria_Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.SecondLevelCriterias", "FirstLevelCriteria_Id1", c => c.Guid());
            CreateIndex("dbo.SecondLevelCriterias", "FirstLevelCriteria_Id");
            CreateIndex("dbo.SecondLevelCriterias", "FirstLevelCriteria_Id1");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CourseWithThirdLevel", "ThirdLevelId", "dbo.ThirdLevelCriterias");
            DropForeignKey("dbo.CourseWithThirdLevel", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.CourseWithSecondLevel", "SecondLevelId", "dbo.SecondLevelCriterias");
            DropForeignKey("dbo.CourseWithSecondLevel", "CourseId", "dbo.Courses");
            DropIndex("dbo.CourseWithThirdLevel", new[] { "ThirdLevelId" });
            DropIndex("dbo.CourseWithThirdLevel", new[] { "CourseId" });
            DropIndex("dbo.CourseWithSecondLevel", new[] { "SecondLevelId" });
            DropIndex("dbo.CourseWithSecondLevel", new[] { "CourseId" });
            DropIndex("dbo.SecondLevelCriterias", new[] { "FirstLevelCriteria_Id1" });
            DropIndex("dbo.SecondLevelCriterias", new[] { "FirstLevelCriteria_Id" });
            AlterColumn("dbo.SecondLevelCriterias", "FirstLevelCriteria_Id1", c => c.Guid(nullable: false));
            AlterColumn("dbo.SecondLevelCriterias", "FirstLevelCriteria_Id", c => c.Guid());
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
