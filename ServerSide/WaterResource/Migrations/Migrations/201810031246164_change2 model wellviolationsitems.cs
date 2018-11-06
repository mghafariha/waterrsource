namespace WaterResource.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change2modelwellviolationsitems : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.WellViolationsItems", "DateViolation", c => c.DateTime());
            AlterColumn("dbo.WellViolationsItems", "DateFile", c => c.DateTime());
            AlterColumn("dbo.WellViolationsItems", "DateMasters", c => c.DateTime());
            AlterColumn("dbo.WellViolationsItems", "DateEnforcement", c => c.DateTime());
            AlterColumn("dbo.WellViolations", "DateFirstWarning", c => c.DateTime());
            AlterColumn("dbo.WellViolations", "SecondWarningDate", c => c.DateTime());
            AlterColumn("dbo.WellViolations", "DateClosed", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WellViolations", "DateClosed", c => c.DateTime(nullable: false));
            AlterColumn("dbo.WellViolations", "SecondWarningDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.WellViolations", "DateFirstWarning", c => c.DateTime(nullable: false));
            AlterColumn("dbo.WellViolationsItems", "DateEnforcement", c => c.DateTime(nullable: false));
            AlterColumn("dbo.WellViolationsItems", "DateMasters", c => c.DateTime(nullable: false));
            AlterColumn("dbo.WellViolationsItems", "DateFile", c => c.DateTime(nullable: false));
            AlterColumn("dbo.WellViolationsItems", "DateViolation", c => c.DateTime(nullable: false));
        }
    }
}
