namespace WaterResource.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _017 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WellViolations", "DateFile", c => c.DateTime(nullable: false));
            AddColumn("dbo.WellViolations", "MeetingFile", c => c.String());
            AddColumn("dbo.WellViolations", "DateExecuteOrder", c => c.DateTime(nullable: false));
            AddColumn("dbo.WellViolations", "ExecuteOrder", c => c.String());
            AddColumn("dbo.WellViolations", "DateCheckFile", c => c.DateTime(nullable: false));
            AddColumn("dbo.WellViolations", "FileWarrant", c => c.String());
            AddColumn("dbo.WellViolations", "DateFileWarrant", c => c.DateTime(nullable: false));
            AddColumn("dbo.WellViolations", "ExecutionFiles", c => c.String());
            AddColumn("dbo.WellViolations", "DateEnforcement", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.WellViolations", "DateEnforcement");
            DropColumn("dbo.WellViolations", "ExecutionFiles");
            DropColumn("dbo.WellViolations", "DateFileWarrant");
            DropColumn("dbo.WellViolations", "FileWarrant");
            DropColumn("dbo.WellViolations", "DateCheckFile");
            DropColumn("dbo.WellViolations", "ExecuteOrder");
            DropColumn("dbo.WellViolations", "DateExecuteOrder");
            DropColumn("dbo.WellViolations", "MeetingFile");
            DropColumn("dbo.WellViolations", "DateFile");
        }
    }
}
