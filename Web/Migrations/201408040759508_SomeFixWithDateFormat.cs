namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SomeFixWithDateFormat : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Sessions", "SignatureTrackCloseTime", c => c.Double(nullable: false));
            AlterColumn("dbo.Sessions", "SignatureTrackOpenTime", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sessions", "SignatureTrackOpenTime", c => c.Int(nullable: false));
            AlterColumn("dbo.Sessions", "SignatureTrackCloseTime", c => c.Int(nullable: false));
        }
    }
}
