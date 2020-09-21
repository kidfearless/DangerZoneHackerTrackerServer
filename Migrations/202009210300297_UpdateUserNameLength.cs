namespace DangerHackerTrackerServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateUserNameLength : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Users", new[] { "UserName" });
            AlterColumn("dbo.Users", "UserName", c => c.String(maxLength: 64, storeType: "nvarchar"));
            CreateIndex("dbo.Users", "UserName", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "UserName" });
            AlterColumn("dbo.Users", "UserName", c => c.String(unicode: false));
            CreateIndex("dbo.Users", "UserName", unique: true);
        }
    }
}
