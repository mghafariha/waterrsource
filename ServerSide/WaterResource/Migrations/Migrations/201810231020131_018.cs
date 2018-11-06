namespace WaterResource.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _018 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.WellViolations", "DateFirstWarning", c => c.DateTime());
            AlterColumn("dbo.WellViolations", "DateFile", c => c.DateTime());
            AlterColumn("dbo.WellViolations", "SecondWarningDate", c => c.DateTime());
            AlterColumn("dbo.WellViolations", "DateExecuteOrder", c => c.DateTime());
            AlterColumn("dbo.WellViolations", "DateCheckFile", c => c.DateTime());
            AlterColumn("dbo.WellViolations", "DateFileWarrant", c => c.DateTime());
            AlterColumn("dbo.WellViolations", "DateClosed", c => c.DateTime());
            AlterColumn("dbo.WellViolations", "DateEnforcement", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WellViolations", "DateEnforcement", c => c.DateTime(nullable: false));
            AlterColumn("dbo.WellViolations", "DateClosed", c => c.DateTime(nullable: false));
            AlterColumn("dbo.WellViolations", "DateFileWarrant", c => c.DateTime(nullable: false));
            AlterColumn("dbo.WellViolations", "DateCheckFile", c => c.DateTime(nullable: false));
            AlterColumn("dbo.WellViolations", "DateExecuteOrder", c => c.DateTime(nullable: false));
            AlterColumn("dbo.WellViolations", "SecondWarningDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.WellViolations", "DateFile", c => c.DateTime(nullable: false));
            AlterColumn("dbo.WellViolations", "DateFirstWarning", c => c.DateTime(nullable: false));
        }
    }
}
