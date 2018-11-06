namespace WaterResource.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _008 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.WellViolations", "DateFirstWarning", c => c.DateTime(nullable: false));
            AlterColumn("dbo.WellViolations", "SecondWarningDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.WellViolations", "DateClosed", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WellViolations", "DateClosed", c => c.DateTime());
            AlterColumn("dbo.WellViolations", "SecondWarningDate", c => c.DateTime());
            AlterColumn("dbo.WellViolations", "DateFirstWarning", c => c.DateTime());
        }
    }
}
