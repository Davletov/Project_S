namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddProfileEntitity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Profile",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        City_CityId = c.Int(),
                        Country_CountryId = c.Int(),
                        ProfileId = c.Long(nullable: false),
                        UserId = c.String(),
                        CreateDate = c.DateTime(),
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
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Profile", "Country_CountryId", "dbo.Countries");
            DropForeignKey("dbo.Profile", "City_CityId", "dbo.Cities");
            DropForeignKey("dbo.Profile", "Id", "dbo.IdentityUsers");

            DropIndex("dbo.Profile", new[] { "Country_CountryId" });
            DropIndex("dbo.Profile", new[] { "City_CityId" });
            DropIndex("dbo.Profile", new[] { "Id" });

            DropTable("dbo.Profile");
        }
    }
}
