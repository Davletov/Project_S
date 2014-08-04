namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCriteriaEntities : DbMigration
    {
        public override void Up()
        {
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
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Profile_ProfileId = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Profiles", t => t.Profile_ProfileId)
                .Index(t => t.Profile_ProfileId);
            
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
                "dbo.Profiles",
                c => new
                    {
                        ProfileId = c.Long(nullable: false, identity: true),
                        UserId = c.String(),
                    })
                .PrimaryKey(t => t.ProfileId);
            
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
                        SecondLevelCriteriaId = c.Int(nullable: false),
                        ThirdLevelCriteriaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FirstLevelCriteriaId)
                .ForeignKey("dbo.SecondLevelCriterias", t => t.SecondLevelCriteriaId, cascadeDelete: true)
                .ForeignKey("dbo.ThirdLevelCriterias", t => t.ThirdLevelCriteriaId, cascadeDelete: true)
                .Index(t => t.SecondLevelCriteriaId)
                .Index(t => t.ThirdLevelCriteriaId);
            
            CreateTable(
                "dbo.SecondLevelCriterias",
                c => new
                    {
                        SecondLevelCriteriaId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Tags = c.String(),
                    })
                .PrimaryKey(t => t.SecondLevelCriteriaId);
            
            CreateTable(
                "dbo.ThirdLevelCriterias",
                c => new
                    {
                        ThirdLevelCriteriaId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Tags = c.String(),
                    })
                .PrimaryKey(t => t.ThirdLevelCriteriaId);
            
            CreateTable(
                "dbo.IdentityRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IdentityUserRoles", "IdentityUser_Id", "dbo.IdentityUsers");
            DropForeignKey("dbo.IdentityUserLogins", "IdentityUser_Id", "dbo.IdentityUsers");
            DropForeignKey("dbo.IdentityUserClaims", "IdentityUser_Id", "dbo.IdentityUsers");
            DropForeignKey("dbo.IdentityUserRoles", "IdentityRole_Id", "dbo.IdentityRoles");
            DropForeignKey("dbo.FirstLevelCriterias", "ThirdLevelCriteriaId", "dbo.ThirdLevelCriterias");
            DropForeignKey("dbo.FirstLevelCriterias", "SecondLevelCriteriaId", "dbo.SecondLevelCriterias");
            DropForeignKey("dbo.IdentityUsers", "Profile_ProfileId", "dbo.Profiles");
            DropIndex("dbo.FirstLevelCriterias", new[] { "ThirdLevelCriteriaId" });
            DropIndex("dbo.FirstLevelCriterias", new[] { "SecondLevelCriteriaId" });
            DropIndex("dbo.IdentityUserRoles", new[] { "IdentityUser_Id" });
            DropIndex("dbo.IdentityUserRoles", new[] { "IdentityRole_Id" });
            DropIndex("dbo.IdentityUserLogins", new[] { "IdentityUser_Id" });
            DropIndex("dbo.IdentityUserClaims", new[] { "IdentityUser_Id" });
            DropIndex("dbo.IdentityUsers", new[] { "Profile_ProfileId" });
            DropTable("dbo.IdentityRoles");
            DropTable("dbo.ThirdLevelCriterias");
            DropTable("dbo.SecondLevelCriterias");
            DropTable("dbo.FirstLevelCriterias");
            DropTable("dbo.CriteriaForCourseras");
            DropTable("dbo.IdentityUserRoles");
            DropTable("dbo.Profiles");
            DropTable("dbo.IdentityUserLogins");
            DropTable("dbo.IdentityUserClaims");
            DropTable("dbo.IdentityUsers");
        }
    }
}
