namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddLocationEntities : DbMigration
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


            AlterColumn("dbo.Sessions", "SignatureTrackCloseTime", c => c.Double(nullable: false));
            AlterColumn("dbo.Sessions", "SignatureTrackOpenTime", c => c.Double(nullable: false));
        }

        public override void Down()
        {
            DropForeignKey("dbo.Cities", "CountryId", "dbo.Countries");
            DropIndex("dbo.Cities", new[] { "CountryId" });

            AlterColumn("dbo.Sessions", "SignatureTrackOpenTime", c => c.Int(nullable: false));
            AlterColumn("dbo.Sessions", "SignatureTrackCloseTime", c => c.Int(nullable: false));

            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
        }
    }
}
