namespace WaterResource.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _006 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.WellVisiteds", "Index", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WellVisiteds", "Index", c => c.Int(nullable: false));
        }
    }
}
