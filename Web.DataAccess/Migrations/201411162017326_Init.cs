namespace Web.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryIdFromApi = c.Int(nullable: false),
                        Name = c.String(),
                        ShortName = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        CourseIdFromApi = c.Int(nullable: false),
                        ShortName = c.String(),
                        Name = c.String(),
                        Language = c.String(),
                        LargeIcon = c.String(),
                        Photo = c.String(),
                        PreviewLink = c.String(),
                        ShortDescription = c.String(),
                        SmallIcon = c.String(),
                        SmallIconHover = c.String(),
                        SubtitleLanguagesCsv = c.String(),
                        IsTranslate = c.Boolean(nullable: false),
                        UniversityLogo = c.String(),
                        UniversityLogoSt = c.String(),
                        Video = c.String(),
                        VideoId = c.String(),
                        AboutTheCourse = c.String(),
                        TargetAudience = c.Int(nullable: false),
                        Faq = c.String(),
                        CourseSyllabus = c.String(),
                        CourseFormat = c.String(),
                        SuggestedReadings = c.String(),
                        Instructor = c.String(),
                        EstimatedClassWorkload = c.String(),
                        AboutTheInstructor = c.String(),
                        RecommendedBackground = c.String(),
                    })
                .PrimaryKey(t => t.CourseId);
            
            CreateTable(
                "dbo.Criteria",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(),
                        Tags = c.String(),
                        ParentId = c.Long(),
                        Criteria_Id = c.Guid(nullable: false),
                        Parent_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Criteria", t => t.Criteria_Id)
                .ForeignKey("dbo.Criteria", t => t.Parent_Id)
                .Index(t => t.Criteria_Id)
                .Index(t => t.Parent_Id);
            
            CreateTable(
                "dbo.Instructors",
                c => new
                    {
                        InstructorId = c.Int(nullable: false, identity: true),
                        InstructorIdFromApi = c.Int(nullable: false),
                        Photo = c.String(),
                        Photo150 = c.String(),
                        Bio = c.String(),
                        PrefixName = c.String(),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        SuffixName = c.String(),
                        FullName = c.String(),
                        Title = c.String(),
                        Department = c.String(),
                        Website = c.String(),
                        WebsiteTwitter = c.String(),
                        WebsiteFacebook = c.String(),
                        WebsiteLinkedin = c.String(),
                        WebsiteGplus = c.String(),
                        ShortName = c.String(),
                    })
                .PrimaryKey(t => t.InstructorId);
            
            CreateTable(
                "dbo.Sessions",
                c => new
                    {
                        SessionId = c.Int(nullable: false, identity: true),
                        SessionIdFromApi = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        HomeLink = c.String(),
                        Status = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                        DurationString = c.String(),
                        StartDay = c.Int(nullable: false),
                        StartMonth = c.Int(nullable: false),
                        StartYear = c.Int(nullable: false),
                        Name = c.String(),
                        SignatureTrackCloseTime = c.Double(nullable: false),
                        SignatureTrackOpenTime = c.Double(nullable: false),
                        SignatureTrackPrice = c.Double(nullable: false),
                        SignatureTrackRegularPrice = c.Single(nullable: false),
                        EligibleForCertificates = c.Boolean(nullable: false),
                        EligibleForSignatureTrack = c.Boolean(nullable: false),
                        CertificateDescription = c.String(),
                        CertificatesReady = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SessionId);
            
            CreateTable(
                "dbo.Universities",
                c => new
                    {
                        UniversityId = c.Int(nullable: false, identity: true),
                        UniversityIdFromApi = c.Int(nullable: false),
                        Name = c.String(),
                        ShortName = c.String(),
                        Description = c.String(),
                        Banner = c.String(),
                        HomeLink = c.String(),
                        Location = c.String(),
                        LocationCity = c.String(),
                        LocationState = c.String(),
                        LocationCountry = c.String(),
                        LocationLat = c.Double(nullable: false),
                        LocationLng = c.Double(nullable: false),
                        ClassLogo = c.String(),
                        Website = c.String(),
                        WebsiteTwitter = c.String(),
                        WebsiteFacebook = c.String(),
                        WebsiteYoutube = c.String(),
                        Logo = c.String(),
                        SquareLogo = c.String(),
                        LandingPageBanner = c.String(),
                    })
                .PrimaryKey(t => t.UniversityId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        ShortNameCountry = c.String(),
                        Name = c.String(),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CityId)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CountryId = c.Int(nullable: false, identity: true),
                        ShortName = c.String(),
                        Name = c.String(),
                        ImageFile = c.String(),
                    })
                .PrimaryKey(t => t.CountryId);
            
            CreateTable(
                "dbo.ProfileCriterias",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        CriteriaId = c.Guid(nullable: false),
                        ProfileId = c.Long(nullable: false),
                        Profile_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Criteria", t => t.CriteriaId, cascadeDelete: true)
                .ForeignKey("dbo.Profile", t => t.Profile_Id)
                .Index(t => t.CriteriaId)
                .Index(t => t.Profile_Id);
            
            CreateTable(
                "dbo.IdentityUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        IdentityUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.IdentityUsers", t => t.IdentityUser_Id)
                .Index(t => t.IdentityUser_Id);
            
            CreateTable(
                "dbo.IdentityUserLogins",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(),
                        ProviderKey = c.String(),
                        IdentityUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.IdentityUsers", t => t.IdentityUser_Id)
                .Index(t => t.IdentityUser_Id);
            
            CreateTable(
                "dbo.IdentityUserRoles",
                c => new
                    {
                        RoleId = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                        IdentityRole_Id = c.String(maxLength: 128),
                        IdentityUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.RoleId, t.UserId })
                .ForeignKey("dbo.IdentityRoles", t => t.IdentityRole_Id)
                .ForeignKey("dbo.IdentityUsers", t => t.IdentityUser_Id)
                .Index(t => t.IdentityRole_Id)
                .Index(t => t.IdentityUser_Id);
            
            CreateTable(
                "dbo.IdentityRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
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
                "dbo.CriteriaCourses",
                c => new
                    {
                        Criteria_Id = c.Guid(nullable: false),
                        Course_CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Criteria_Id, t.Course_CourseId })
                .ForeignKey("dbo.Criteria", t => t.Criteria_Id, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Course_CourseId, cascadeDelete: true)
                .Index(t => t.Criteria_Id)
                .Index(t => t.Course_CourseId);
            
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
            
            CreateTable(
                "dbo.Profile",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        ProfileId = c.Long(nullable: false),
                        UserId = c.String(),
                        CreateDate = c.DateTime(),
                        LoginName = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        BirthDay = c.Int(nullable: false),
                        BirthMonth = c.Int(nullable: false),
                        BirthYear = c.Int(nullable: false),
                        Country = c.Int(nullable: false),
                        City = c.Int(nullable: false),
                        UserSocialStatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.IdentityUsers", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Profile", "Id", "dbo.IdentityUsers");
            DropForeignKey("dbo.IdentityUserRoles", "IdentityUser_Id", "dbo.IdentityUsers");
            DropForeignKey("dbo.IdentityUserLogins", "IdentityUser_Id", "dbo.IdentityUsers");
            DropForeignKey("dbo.IdentityUserClaims", "IdentityUser_Id", "dbo.IdentityUsers");
            DropForeignKey("dbo.IdentityUserRoles", "IdentityRole_Id", "dbo.IdentityRoles");
            DropForeignKey("dbo.ProfileCriterias", "Profile_Id", "dbo.Profile");
            DropForeignKey("dbo.ProfileCriterias", "CriteriaId", "dbo.Criteria");
            DropForeignKey("dbo.Cities", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.CourseUniversities", "UniversityId", "dbo.Universities");
            DropForeignKey("dbo.CourseUniversities", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.CourseSessions", "SessionId", "dbo.Sessions");
            DropForeignKey("dbo.CourseSessions", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.CourseInstructors", "InstructorId", "dbo.Instructors");
            DropForeignKey("dbo.CourseInstructors", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Criteria", "Parent_Id", "dbo.Criteria");
            DropForeignKey("dbo.CriteriaCourses", "Course_CourseId", "dbo.Courses");
            DropForeignKey("dbo.CriteriaCourses", "Criteria_Id", "dbo.Criteria");
            DropForeignKey("dbo.Criteria", "Criteria_Id", "dbo.Criteria");
            DropForeignKey("dbo.CourseCategories", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.CourseCategories", "CourseId", "dbo.Courses");
            DropIndex("dbo.Profile", new[] { "Id" });
            DropIndex("dbo.CourseUniversities", new[] { "UniversityId" });
            DropIndex("dbo.CourseUniversities", new[] { "CourseId" });
            DropIndex("dbo.CourseSessions", new[] { "SessionId" });
            DropIndex("dbo.CourseSessions", new[] { "CourseId" });
            DropIndex("dbo.CourseInstructors", new[] { "InstructorId" });
            DropIndex("dbo.CourseInstructors", new[] { "CourseId" });
            DropIndex("dbo.CriteriaCourses", new[] { "Course_CourseId" });
            DropIndex("dbo.CriteriaCourses", new[] { "Criteria_Id" });
            DropIndex("dbo.CourseCategories", new[] { "CategoryId" });
            DropIndex("dbo.CourseCategories", new[] { "CourseId" });
            DropIndex("dbo.IdentityUserRoles", new[] { "IdentityUser_Id" });
            DropIndex("dbo.IdentityUserRoles", new[] { "IdentityRole_Id" });
            DropIndex("dbo.IdentityUserLogins", new[] { "IdentityUser_Id" });
            DropIndex("dbo.IdentityUserClaims", new[] { "IdentityUser_Id" });
            DropIndex("dbo.ProfileCriterias", new[] { "Profile_Id" });
            DropIndex("dbo.ProfileCriterias", new[] { "CriteriaId" });
            DropIndex("dbo.Cities", new[] { "CountryId" });
            DropIndex("dbo.Criteria", new[] { "Parent_Id" });
            DropIndex("dbo.Criteria", new[] { "Criteria_Id" });
            DropTable("dbo.Profile");
            DropTable("dbo.CourseUniversities");
            DropTable("dbo.CourseSessions");
            DropTable("dbo.CourseInstructors");
            DropTable("dbo.CriteriaCourses");
            DropTable("dbo.CourseCategories");
            DropTable("dbo.IdentityRoles");
            DropTable("dbo.IdentityUserRoles");
            DropTable("dbo.IdentityUserLogins");
            DropTable("dbo.IdentityUserClaims");
            DropTable("dbo.IdentityUsers");
            DropTable("dbo.ProfileCriterias");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
            DropTable("dbo.Universities");
            DropTable("dbo.Sessions");
            DropTable("dbo.Instructors");
            DropTable("dbo.Criteria");
            DropTable("dbo.Courses");
            DropTable("dbo.Categories");
        }
    }
}
