namespace Web.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixCriteriaChildrenRelation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Criteria", "Criteria_Id", "dbo.Criteria");
            DropIndex("dbo.Criteria", new[] { "Criteria_Id" });
            CreateTable(
                "dbo.CriteriaChildren",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ChildrenId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Id, t.ChildrenId })
                .ForeignKey("dbo.Criteria", t => t.Id)
                .ForeignKey("dbo.Criteria", t => t.ChildrenId)
                .Index(t => t.Id)
                .Index(t => t.ChildrenId);
            
            DropColumn("dbo.Criteria", "Criteria_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Criteria", "Criteria_Id", c => c.Guid(nullable: false));
            DropForeignKey("dbo.CriteriaChildren", "ChildrenId", "dbo.Criteria");
            DropForeignKey("dbo.CriteriaChildren", "Id", "dbo.Criteria");
            DropIndex("dbo.CriteriaChildren", new[] { "ChildrenId" });
            DropIndex("dbo.CriteriaChildren", new[] { "Id" });
            DropTable("dbo.CriteriaChildren");
            CreateIndex("dbo.Criteria", "Criteria_Id");
            AddForeignKey("dbo.Criteria", "Criteria_Id", "dbo.Criteria", "Id");
        }
    }
}
