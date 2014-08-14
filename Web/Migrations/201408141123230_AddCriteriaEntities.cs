namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddCriteriaEntities : DbMigration
    {
        public override void Up()
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
            
            CreateTable(
                "dbo.FirstLevelCriterias",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(),
                        Tags = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SecondLevelCriterias",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(),
                        Tags = c.String(),
                        FirstLevelCriteria_Id = c.Guid(),
                        FirstLevelCriteria_Id1 = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FirstLevelCriterias", t => t.FirstLevelCriteria_Id)
                .ForeignKey("dbo.FirstLevelCriterias", t => t.FirstLevelCriteria_Id1, cascadeDelete: true)
                .Index(t => t.FirstLevelCriteria_Id)
                .Index(t => t.FirstLevelCriteria_Id1);
            
            CreateTable(
                "dbo.ThirdLevelCriterias",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(),
                        Tags = c.String(),
                        SecondLevelCriteria_Id = c.Guid(),
                        SecondLevelCriteria_Id1 = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SecondLevelCriterias", t => t.SecondLevelCriteria_Id)
                .ForeignKey("dbo.SecondLevelCriterias", t => t.SecondLevelCriteria_Id1, cascadeDelete: true)
                .Index(t => t.SecondLevelCriteria_Id)
                .Index(t => t.SecondLevelCriteria_Id1);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SecondLevelCriterias", "FirstLevelCriteria_Id1", "dbo.FirstLevelCriterias");
            DropForeignKey("dbo.ThirdLevelCriterias", "SecondLevelCriteria_Id1", "dbo.SecondLevelCriterias");
            DropForeignKey("dbo.ThirdLevelCriterias", "SecondLevelCriteria_Id", "dbo.SecondLevelCriterias");
            DropForeignKey("dbo.SecondLevelCriterias", "FirstLevelCriteria_Id", "dbo.FirstLevelCriterias");

            DropIndex("dbo.ThirdLevelCriterias", new[] { "SecondLevelCriteria_Id1" });
            DropIndex("dbo.ThirdLevelCriterias", new[] { "SecondLevelCriteria_Id" });
            DropIndex("dbo.SecondLevelCriterias", new[] { "FirstLevelCriteria_Id1" });
            DropIndex("dbo.SecondLevelCriterias", new[] { "FirstLevelCriteria_Id" });

            DropTable("dbo.ThirdLevelCriterias");
            DropTable("dbo.SecondLevelCriterias");
            DropTable("dbo.FirstLevelCriterias");
            DropTable("dbo.CriteriaForCourseras");
        }
    }
}
