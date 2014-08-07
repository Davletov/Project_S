namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEntities : DbMigration
    {
        public override void Up()
        {
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
                        FirstLevelCriteriaId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Tags = c.String(),
                    })
                .PrimaryKey(t => t.FirstLevelCriteriaId);
            
            CreateTable(
                "dbo.SecondLevelCriterias",
                c => new
                    {
                        SecondLevelCriteriaId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Tags = c.String(),
                        FirstLevelCriteria_FirstLevelCriteriaId = c.Int(),
                        FirstLevelCriteria_FirstLevelCriteriaId1 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SecondLevelCriteriaId)
                .ForeignKey("dbo.FirstLevelCriterias", t => t.FirstLevelCriteria_FirstLevelCriteriaId)
                .ForeignKey("dbo.FirstLevelCriterias", t => t.FirstLevelCriteria_FirstLevelCriteriaId1, cascadeDelete: true)
                .Index(t => t.FirstLevelCriteria_FirstLevelCriteriaId)
                .Index(t => t.FirstLevelCriteria_FirstLevelCriteriaId1);
            
            CreateTable(
                "dbo.ThirdLevelCriterias",
                c => new
                    {
                        ThirdLevelCriteriaId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Tags = c.String(),
                        SecondLevelCriteria_SecondLevelCriteriaId = c.Int(),
                        SecondLevelCriteria_SecondLevelCriteriaId1 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ThirdLevelCriteriaId)
                .ForeignKey("dbo.SecondLevelCriterias", t => t.SecondLevelCriteria_SecondLevelCriteriaId)
                .ForeignKey("dbo.SecondLevelCriterias", t => t.SecondLevelCriteria_SecondLevelCriteriaId1, cascadeDelete: true)
                .Index(t => t.SecondLevelCriteria_SecondLevelCriteriaId)
                .Index(t => t.SecondLevelCriteria_SecondLevelCriteriaId1);
            
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
                "dbo.Profile",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        City_CityId = c.Int(),
                        Country_CountryId = c.Int(),
                        ProfileId = c.Long(nullable: false),
                        UserId = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        LoginName = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        BirthDay = c.Int(nullable: false),
                        BirthMonth = c.Int(nullable: false),
                        BirthYear = c.Int(nullable: false),
                        UserSocialStatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.IdentityUsers", t => t.Id)
                .ForeignKey("dbo.Cities", t => t.City_CityId)
                .ForeignKey("dbo.Countries", t => t.Country_CountryId)
                .Index(t => t.Id)
                .Index(t => t.City_CityId)
                .Index(t => t.Country_CountryId);
            
            AlterColumn("dbo.Sessions", "SignatureTrackCloseTime", c => c.Double(nullable: false));
            AlterColumn("dbo.Sessions", "SignatureTrackOpenTime", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Profile", "Country_CountryId", "dbo.Countries");
            DropForeignKey("dbo.Profile", "City_CityId", "dbo.Cities");
            DropForeignKey("dbo.Profile", "Id", "dbo.IdentityUsers");
            DropForeignKey("dbo.IdentityUserRoles", "IdentityUser_Id", "dbo.IdentityUsers");
            DropForeignKey("dbo.IdentityUserLogins", "IdentityUser_Id", "dbo.IdentityUsers");
            DropForeignKey("dbo.IdentityUserClaims", "IdentityUser_Id", "dbo.IdentityUsers");
            DropForeignKey("dbo.IdentityUserRoles", "IdentityRole_Id", "dbo.IdentityRoles");
            DropForeignKey("dbo.SecondLevelCriterias", "FirstLevelCriteria_FirstLevelCriteriaId1", "dbo.FirstLevelCriterias");
            DropForeignKey("dbo.ThirdLevelCriterias", "SecondLevelCriteria_SecondLevelCriteriaId1", "dbo.SecondLevelCriterias");
            DropForeignKey("dbo.ThirdLevelCriterias", "SecondLevelCriteria_SecondLevelCriteriaId", "dbo.SecondLevelCriterias");
            DropForeignKey("dbo.SecondLevelCriterias", "FirstLevelCriteria_FirstLevelCriteriaId", "dbo.FirstLevelCriterias");
            DropForeignKey("dbo.Cities", "CountryId", "dbo.Countries");
            DropIndex("dbo.Profile", new[] { "Country_CountryId" });
            DropIndex("dbo.Profile", new[] { "City_CityId" });
            DropIndex("dbo.Profile", new[] { "Id" });
            DropIndex("dbo.IdentityUserRoles", new[] { "IdentityUser_Id" });
            DropIndex("dbo.IdentityUserRoles", new[] { "IdentityRole_Id" });
            DropIndex("dbo.IdentityUserLogins", new[] { "IdentityUser_Id" });
            DropIndex("dbo.IdentityUserClaims", new[] { "IdentityUser_Id" });
            DropIndex("dbo.ThirdLevelCriterias", new[] { "SecondLevelCriteria_SecondLevelCriteriaId1" });
            DropIndex("dbo.ThirdLevelCriterias", new[] { "SecondLevelCriteria_SecondLevelCriteriaId" });
            DropIndex("dbo.SecondLevelCriterias", new[] { "FirstLevelCriteria_FirstLevelCriteriaId1" });
            DropIndex("dbo.SecondLevelCriterias", new[] { "FirstLevelCriteria_FirstLevelCriteriaId" });
            DropIndex("dbo.Cities", new[] { "CountryId" });
            AlterColumn("dbo.Sessions", "SignatureTrackOpenTime", c => c.Int(nullable: false));
            AlterColumn("dbo.Sessions", "SignatureTrackCloseTime", c => c.Int(nullable: false));
            DropTable("dbo.Profile");
            DropTable("dbo.IdentityRoles");
            DropTable("dbo.IdentityUserRoles");
            DropTable("dbo.IdentityUserLogins");
            DropTable("dbo.IdentityUserClaims");
            DropTable("dbo.IdentityUsers");
            DropTable("dbo.ThirdLevelCriterias");
            DropTable("dbo.SecondLevelCriterias");
            DropTable("dbo.FirstLevelCriterias");
            DropTable("dbo.CriteriaForCourseras");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
        }
    }
}
