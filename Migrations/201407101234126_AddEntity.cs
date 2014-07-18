namespace Testing.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddEntity : DbMigration
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
                        SignatureTrackCloseTime = c.Int(nullable: false),
                        SignatureTrackOpenTime = c.Int(nullable: false),
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
        }
        
        public override void Down()
        {
            DropTable("dbo.Universities");
            DropTable("dbo.Sessions");
            DropTable("dbo.Instructors");
            DropTable("dbo.Courses");
            DropTable("dbo.Categories");
        }
    }
}
