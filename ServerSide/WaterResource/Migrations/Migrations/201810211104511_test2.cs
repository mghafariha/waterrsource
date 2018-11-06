namespace WaterResource.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AreaStudies", "VisitExpert", c => c.Guid(nullable: false));
            AlterColumn("dbo.Cities", "OmorExpert", c => c.Guid(nullable: false));
            AlterColumn("dbo.Cities", "AreaManager", c => c.Guid(nullable: false));
            AlterColumn("dbo.Cities", "LegalExpert", c => c.Guid(nullable: false));
            AlterColumn("dbo.WellVisiteds", "VisitExpert", c => c.String(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WellVisiteds", "VisitExpert", c => c.Int(nullable: false));
            AlterColumn("dbo.Cities", "LegalExpert", c => c.Int(nullable: false));
            AlterColumn("dbo.Cities", "AreaManager", c => c.Int(nullable: false));
            AlterColumn("dbo.Cities", "OmorExpert", c => c.Int(nullable: false));
            AlterColumn("dbo.AreaStudies", "VisitExpert", c => c.Guid(nullable: true));
        }
    }
}
