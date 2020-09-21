namespace DangerHackerTrackerServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cheaters",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ThreatLevel = c.Byte(nullable: false),
                        CheatList = c.String(maxLength: 128, storeType: "nvarchar"),
                        LastKnownName = c.String(maxLength: 64, storeType: "nvarchar"),
                        Submitter_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.Submitter_ID)
                .Index(t => t.Submitter_ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.UserName, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cheaters", "Submitter_ID", "dbo.Users");
            DropIndex("dbo.Users", new[] { "UserName" });
            DropIndex("dbo.Cheaters", new[] { "Submitter_ID" });
            DropTable("dbo.Users");
            DropTable("dbo.Cheaters");
        }
    }
}
