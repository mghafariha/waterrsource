namespace water2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _002 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WellVisiteds", "Profile", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.WellVisiteds", "Profile");
        }
    }
}
