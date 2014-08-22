namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixProfile : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Profile", "City_CityId", "dbo.Cities");
            DropForeignKey("dbo.Profile", "Country_CountryId", "dbo.Countries");
            DropIndex("dbo.Profile", new[] { "City_CityId" });
            DropIndex("dbo.Profile", new[] { "Country_CountryId" });
            AddColumn("dbo.Profile", "Country", c => c.Int(nullable: false));
            AddColumn("dbo.Profile", "City", c => c.Int(nullable: false));
            DropColumn("dbo.Profile", "City_CityId");
            DropColumn("dbo.Profile", "Country_CountryId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Profile", "Country_CountryId", c => c.Int());
            AddColumn("dbo.Profile", "City_CityId", c => c.Int());
            DropColumn("dbo.Profile", "City");
            DropColumn("dbo.Profile", "Country");
            CreateIndex("dbo.Profile", "Country_CountryId");
            CreateIndex("dbo.Profile", "City_CityId");
            AddForeignKey("dbo.Profile", "Country_CountryId", "dbo.Countries", "CountryId");
            AddForeignKey("dbo.Profile", "City_CityId", "dbo.Cities", "CityId");
        }
    }
}
