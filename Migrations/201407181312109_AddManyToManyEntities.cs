namespace Testing.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddManyToManyEntities : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CourseCategories",
                c => new
                {
                    CourseId = c.Int(nullable: false),
                    CategoryId = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.CourseId, t.CategoryId })
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CourseId)
                .Index(t => t.CategoryId);

            CreateTable(
                "dbo.CourseInstructors",
                c => new
                    {
                        CourseId = c.Int(nullable: false),
                        InstructorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CourseId, t.InstructorId })
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Instructors", t => t.InstructorId, cascadeDelete: true)
                .Index(t => t.CourseId)
                .Index(t => t.InstructorId);
            
            CreateTable(
                "dbo.CourseSessions",
                c => new
                    {
                        CourseId = c.Int(nullable: false),
                        SessionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CourseId, t.SessionId })
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Sessions", t => t.SessionId, cascadeDelete: true)
                .Index(t => t.CourseId)
                .Index(t => t.SessionId);
            
            CreateTable(
                "dbo.CourseUniversities",
                c => new
                    {
                        CourseId = c.Int(nullable: false),
                        UniversityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CourseId, t.UniversityId })
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Universities", t => t.UniversityId, cascadeDelete: true)
                .Index(t => t.CourseId)
                .Index(t => t.UniversityId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CourseUniversities", "UniversityId", "dbo.Universities");
            DropForeignKey("dbo.CourseUniversities", "CourseId", "dbo.Courses");

            DropForeignKey("dbo.CourseSessions", "SessionId", "dbo.Sessions");
            DropForeignKey("dbo.CourseSessions", "CourseId", "dbo.Courses");

            DropForeignKey("dbo.CourseInstructors", "InstructorId", "dbo.Instructors");
            DropForeignKey("dbo.CourseInstructors", "CourseId", "dbo.Courses");

            DropForeignKey("dbo.CourseCategories", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.CourseCategories", "CourseId", "dbo.Courses");

            DropIndex("dbo.CourseUniversities", new[] { "UniversityId" });
            DropIndex("dbo.CourseUniversities", new[] { "CourseId" });

            DropIndex("dbo.CourseSessions", new[] { "SessionId" });
            DropIndex("dbo.CourseSessions", new[] { "CourseId" });

            DropIndex("dbo.CourseInstructors", new[] { "InstructorId" });
            DropIndex("dbo.CourseInstructors", new[] { "CourseId" });

            DropIndex("dbo.CourseCategories", new[] { "CategoryId" });
            DropIndex("dbo.CourseCategories", new[] { "CourseId" });

            DropTable("dbo.CourseUniversities");
            DropTable("dbo.CourseSessions");
            DropTable("dbo.CourseInstructors");
            DropTable("dbo.CourseCategories");
        }
    }
}
