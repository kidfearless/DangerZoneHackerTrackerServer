namespace DangerHackerTrackerServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateThreatLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cheaters", "ThreatLevel", c => c.Short(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cheaters", "ThreatLevel", c => c.Byte(nullable: false));
        }
    }
}
