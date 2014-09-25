namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteCategoriesFromGlobalCriterias : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CategoryWithFirstLevel", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.CategoryWithFirstLevel", "FirstLevelId", "dbo.FirstLevelCriterias");
            DropForeignKey("dbo.CategoryWithSecondLevel", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.CategoryWithSecondLevel", "SecondLevelId", "dbo.SecondLevelCriterias");
            DropForeignKey("dbo.CategoryWithThirdLevel", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.CategoryWithThirdLevel", "ThirdLevelId", "dbo.ThirdLevelCriterias");
            DropIndex("dbo.CategoryWithFirstLevel", new[] { "CategoryId" });
            DropIndex("dbo.CategoryWithFirstLevel", new[] { "FirstLevelId" });
            DropIndex("dbo.CategoryWithSecondLevel", new[] { "CategoryId" });
            DropIndex("dbo.CategoryWithSecondLevel", new[] { "SecondLevelId" });
            DropIndex("dbo.CategoryWithThirdLevel", new[] { "CategoryId" });
            DropIndex("dbo.CategoryWithThirdLevel", new[] { "ThirdLevelId" });
            DropTable("dbo.CategoryWithFirstLevel");
            DropTable("dbo.CategoryWithSecondLevel");
            DropTable("dbo.CategoryWithThirdLevel");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.CategoryWithThirdLevel",
                c => new
                    {
                        CategoryId = c.Int(nullable: false),
                        ThirdLevelId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.CategoryId, t.ThirdLevelId });
            
            CreateTable(
                "dbo.CategoryWithSecondLevel",
                c => new
                    {
                        CategoryId = c.Int(nullable: false),
                        SecondLevelId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.CategoryId, t.SecondLevelId });
            
            CreateTable(
                "dbo.CategoryWithFirstLevel",
                c => new
                    {
                        CategoryId = c.Int(nullable: false),
                        FirstLevelId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.CategoryId, t.FirstLevelId });
            
            CreateIndex("dbo.CategoryWithThirdLevel", "ThirdLevelId");
            CreateIndex("dbo.CategoryWithThirdLevel", "CategoryId");
            CreateIndex("dbo.CategoryWithSecondLevel", "SecondLevelId");
            CreateIndex("dbo.CategoryWithSecondLevel", "CategoryId");
            CreateIndex("dbo.CategoryWithFirstLevel", "FirstLevelId");
            CreateIndex("dbo.CategoryWithFirstLevel", "CategoryId");
            AddForeignKey("dbo.CategoryWithThirdLevel", "ThirdLevelId", "dbo.ThirdLevelCriterias", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CategoryWithThirdLevel", "CategoryId", "dbo.Categories", "CategoryId", cascadeDelete: true);
            AddForeignKey("dbo.CategoryWithSecondLevel", "SecondLevelId", "dbo.SecondLevelCriterias", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CategoryWithSecondLevel", "CategoryId", "dbo.Categories", "CategoryId", cascadeDelete: true);
            AddForeignKey("dbo.CategoryWithFirstLevel", "FirstLevelId", "dbo.FirstLevelCriterias", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CategoryWithFirstLevel", "CategoryId", "dbo.Categories", "CategoryId", cascadeDelete: true);
        }
    }
}
