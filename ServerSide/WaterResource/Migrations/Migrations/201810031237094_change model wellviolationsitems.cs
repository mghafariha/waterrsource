namespace WaterResource.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changemodelwellviolationsitems : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.WellViolationItems", newName: "WellViolationsItems");
            AlterColumn("dbo.WellViolationsItems", "TypeViolation", c => c.String());
            AlterColumn("dbo.WellViolationsItems", "Attachment", c => c.String());
            AlterColumn("dbo.WellViolationsItems", "RecipeProsecutor", c => c.String());
            AlterColumn("dbo.WellViolationsItems", "FileViolation", c => c.String());
            AlterColumn("dbo.WellViolationsItems", "MeetingFile", c => c.String());
            AlterColumn("dbo.WellViolationsItems", "CourtJudgment", c => c.String());
            AlterColumn("dbo.WellViolationsItems", "FileMasters", c => c.String());
            AlterColumn("dbo.WellViolationsItems", "CourtJudgment2", c => c.String());
            AlterColumn("dbo.WellViolationsItems", "FileCourtJudgment2", c => c.String());
            AlterColumn("dbo.WellViolationsItems", "ExecutionFiles", c => c.String());
            AlterColumn("dbo.WellViolations", "DeadlineReferralFirstWarning", c => c.String());
            AlterColumn("dbo.WellViolations", "FileFirstWarning", c => c.String());
            AlterColumn("dbo.WellViolations", "DeadlineReferralSecondWarning", c => c.String());
            AlterColumn("dbo.WellViolations", "FileSecondWarning", c => c.String());
            AlterColumn("dbo.WellViolations", "CheckFile", c => c.String());
            AlterColumn("dbo.WellViolations", "WellPosition", c => c.String());
            AlterColumn("dbo.WellViolations", "Violations", c => c.String());
            AlterColumn("dbo.WellViolations", "FileClosed", c => c.String());
            AlterColumn("dbo.WellViolations", "SavingFiles", c => c.String());
            AlterColumn("dbo.WellViolations", "ResultActions", c => c.String());
            AlterColumn("dbo.WellViolations", "Status", c => c.String());
            AlterColumn("dbo.WellViolations", "Description", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WellViolations", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.WellViolations", "Status", c => c.String(nullable: false));
            AlterColumn("dbo.WellViolations", "ResultActions", c => c.String(nullable: false));
            AlterColumn("dbo.WellViolations", "SavingFiles", c => c.String(nullable: false));
            AlterColumn("dbo.WellViolations", "FileClosed", c => c.String(nullable: false));
            AlterColumn("dbo.WellViolations", "Violations", c => c.String(nullable: false));
            AlterColumn("dbo.WellViolations", "WellPosition", c => c.String(nullable: false));
            AlterColumn("dbo.WellViolations", "CheckFile", c => c.String(nullable: false));
            AlterColumn("dbo.WellViolations", "FileSecondWarning", c => c.String(nullable: false));
            AlterColumn("dbo.WellViolations", "DeadlineReferralSecondWarning", c => c.String(nullable: false));
            AlterColumn("dbo.WellViolations", "FileFirstWarning", c => c.String(nullable: false));
            AlterColumn("dbo.WellViolations", "DeadlineReferralFirstWarning", c => c.String(nullable: false));
            AlterColumn("dbo.WellViolationsItems", "ExecutionFiles", c => c.String(nullable: false));
            AlterColumn("dbo.WellViolationsItems", "FileCourtJudgment2", c => c.String(nullable: false));
            AlterColumn("dbo.WellViolationsItems", "CourtJudgment2", c => c.String(nullable: false));
            AlterColumn("dbo.WellViolationsItems", "FileMasters", c => c.String(nullable: false));
            AlterColumn("dbo.WellViolationsItems", "CourtJudgment", c => c.String(nullable: false));
            AlterColumn("dbo.WellViolationsItems", "MeetingFile", c => c.String(nullable: false));
            AlterColumn("dbo.WellViolationsItems", "FileViolation", c => c.String(nullable: false));
            AlterColumn("dbo.WellViolationsItems", "RecipeProsecutor", c => c.String(nullable: false));
            AlterColumn("dbo.WellViolationsItems", "Attachment", c => c.String(nullable: false));
            AlterColumn("dbo.WellViolationsItems", "TypeViolation", c => c.String(nullable: false));
            RenameTable(name: "dbo.WellViolationsItems", newName: "WellViolationItems");
        }
    }
}
