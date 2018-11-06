namespace WaterResource.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tmp34 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AreaStudies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        CityID = c.Int(nullable: false),
                        Code = c.String(nullable: false),
                        Kind = c.String(nullable: false),
                        Pilot = c.String(nullable: false),
                        VisitExpert = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cities", t => t.CityID, cascadeDelete: true)
                .Index(t => t.CityID);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        OmorExpert = c.Guid(nullable: false),
                        AreaManager = c.Guid(nullable: false),
                        LegalExpert = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.InspectionDepartments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Index = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.OtherTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ClassName = c.String(),
                        FieldName = c.String(),
                        Type = c.String(),
                        Options = c.String(),
                        IsMultiple = c.Boolean(nullable: false),
                        TitleField = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Plains",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        AreaStudyID = c.Int(nullable: false),
                        Status = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AreaStudies", t => t.AreaStudyID, cascadeDelete: true)
                .Index(t => t.AreaStudyID);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Hometown = c.String(),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.WellProfiles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ApprovedVolume = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WorkHours = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FlowWater = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiameterWaterPipe = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PowerlevelElectricity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PowerlevelDiesel = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LandArea = c.Decimal(nullable: false, precision: 18, scale: 2),
                        KindConsumptionWater = c.String(),
                        Pipeline = c.String(),
                        WellDepth = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WaterSurface = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LongitudeWell = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LatitudeWell = c.Decimal(nullable: false, precision: 18, scale: 2),
                        licenseKind = c.String(),
                        licenseNumber = c.String(),
                        licenseDate = c.DateTime(),
                        licenseNumberDigPrimary = c.String(),
                        licenseDateDigPrimary = c.DateTime(),
                        Typelicense = c.String(),
                        Village = c.String(),
                        StudyAreaID = c.Int(nullable: false),
                        PlainID = c.Int(nullable: false),
                        OwnerName = c.String(),
                        fathersName = c.String(),
                        NumberPartners = c.Int(nullable: false),
                        Index = c.String(),
                        SerialNumber = c.String(),
                        FormType = c.String(),
                        SubscriptionCode = c.String(),
                        zone = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TypeWell = c.String(),
                        CodeConservationStudies = c.String(),
                        WaterSystem = c.String(),
                        CityID = c.Int(nullable: false),
                        Meter = c.String(),
                        DateInstallationMeter = c.DateTime(nullable: false),
                        WaterAffairs = c.String(),
                        DrillingDevice = c.String(),
                        TypeDigging = c.String(),
                        CultivarType = c.String(),
                        ArtifactsType = c.String(),
                        NationalNumber = c.String(),
                        LicenseFloorBreaker = c.String(),
                        AllowanceFloorBreaker = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DisplacemenLicense = c.String(),
                        finalDisplacemenLicense = c.DateTime(),
                        DisplacementRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BackgroundObstruction = c.String(),
                        EC = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cities", t => t.CityID, cascadeDelete: true)
                .ForeignKey("dbo.Plains", t => t.PlainID, cascadeDelete: true)
                .ForeignKey("dbo.AreaStudies", t => t.StudyAreaID, cascadeDelete: true)
                .Index(t => t.StudyAreaID)
                .Index(t => t.PlainID)
                .Index(t => t.CityID);
            
            CreateTable(
                "dbo.WellViolationsItems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        InfractionsWellID = c.Int(nullable: false),
                        TypeViolation = c.String(),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Attachment = c.String(),
                        Description = c.String(),
                        RecipeProsecutor = c.String(),
                        FileViolation = c.String(),
                        DateViolation = c.DateTime(),
                        MeetingFile = c.String(),
                        DateFile = c.DateTime(),
                        CourtJudgment = c.String(),
                        DateMasters = c.DateTime(),
                        FileMasters = c.String(),
                        CourtJudgment2 = c.String(),
                        FileCourtJudgment2 = c.String(),
                        DateEnforcement = c.DateTime(),
                        ExecutionFiles = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.WellViolations", t => t.InfractionsWellID, cascadeDelete: true)
                .Index(t => t.InfractionsWellID);
            
            CreateTable(
                "dbo.WellViolations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DateFirstWarning = c.DateTime(),
                        DeadlineReferralFirstWarning = c.String(),
                        FileFirstWarning = c.String(),
                        DateFile = c.DateTime(),
                        MeetingFile = c.String(),
                        SecondWarningDate = c.DateTime(),
                        DeadlineReferralSecondWarning = c.String(),
                        FileSecondWarning = c.String(),
                        DateExecuteOrder = c.DateTime(),
                        ExecuteOrder = c.String(),
                        CheckFile = c.String(),
                        DateCheckFile = c.DateTime(),
                        FileWarrant = c.String(),
                        DateFileWarrant = c.DateTime(),
                        WellPosition = c.String(),
                        NumberInFraction = c.Int(nullable: false),
                        Violations = c.String(),
                        FileClosed = c.String(),
                        DateClosed = c.DateTime(),
                        ExecutionFiles = c.String(),
                        SavingFiles = c.String(),
                        DateEnforcement = c.DateTime(),
                        SavingAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ResultActions = c.String(),
                        Status = c.String(),
                        Description = c.String(),
                        WellVisitedID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.WellVisiteds", t => t.WellVisitedID, cascadeDelete: true)
                .Index(t => t.WellVisitedID);
            
            CreateTable(
                "dbo.WellVisiteds",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        WellProfileID = c.Int(nullable: false),
                        PresentSituation = c.String(),
                        InArea = c.String(),
                        NationalNumber = c.String(),
                        Mobile = c.Int(nullable: false),
                        SubscriptionElectricity = c.String(),
                        SerialNumberMeter = c.String(),
                        SerialNumberModem = c.String(),
                        ManufacturerMeter = c.String(),
                        DateInstallationMeter = c.DateTime(),
                        TypeMeter = c.String(),
                        Meter = c.String(),
                        NumberMeters = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WaterSystem = c.String(),
                        ApprovedVolume = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WorkHours = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WaterMeasurementMethod = c.String(),
                        EC = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FlowWater = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiameterWaterPipe = c.Decimal(nullable: false, precision: 18, scale: 2),
                        YearDig = c.Int(nullable: false),
                        PowerlevelElectricity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PowerlevelDiesel = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ArtifactsType = c.String(),
                        AreaUnderCultivation = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CultivarType = c.String(),
                        KindConsumptionWater = c.String(),
                        Pipeline = c.String(),
                        WellDepth = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WaterSurface = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LongitudeWell = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LatitudeWell = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DateCensus = c.DateTime(),
                        VisitExpertID = c.Int(nullable: false),
                        Status = c.String(),
                        DateRegistration = c.DateTime(),
                        DistrictAdministratorApprovalDate = c.DateTime(),
                        RegionalWaterCertificateApprovalDate = c.DateTime(),
                        OwnerPostalCode = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Village = c.String(),
                        zone = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TypeWell = c.String(),
                        NumberPartners = c.Int(nullable: false),
                        StatusMeter = c.String(),
                        DrillingDevice = c.String(),
                        TypeDigging = c.String(),
                        licenseDig = c.String(),
                        licenseUse = c.String(),
                        ExtendedlicenseUse = c.String(),
                        BackgroundObstruction = c.String(),
                        ChangeTypeUse = c.String(),
                        FloorBreakerillegal = c.String(),
                        TransferWate = c.String(),
                        AddedExtraction = c.String(),
                        RateAddedExtraction = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Displacementillegal = c.String(),
                        DisplacementRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Artifactsillegal = c.String(),
                        WaterSupply = c.String(),
                        Desalinationillegal = c.String(),
                        OtherViolations = c.String(),
                        Pictures = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.InspectionDepartments", t => t.VisitExpertID, cascadeDelete: true)
                .ForeignKey("dbo.WellProfiles", t => t.WellProfileID, cascadeDelete: true)
                .Index(t => t.WellProfileID)
                .Index(t => t.VisitExpertID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WellViolationsItems", "InfractionsWellID", "dbo.WellViolations");
            DropForeignKey("dbo.WellViolations", "WellVisitedID", "dbo.WellVisiteds");
            DropForeignKey("dbo.WellVisiteds", "WellProfileID", "dbo.WellProfiles");
            DropForeignKey("dbo.WellVisiteds", "VisitExpertID", "dbo.InspectionDepartments");
            DropForeignKey("dbo.WellProfiles", "StudyAreaID", "dbo.AreaStudies");
            DropForeignKey("dbo.WellProfiles", "PlainID", "dbo.Plains");
            DropForeignKey("dbo.WellProfiles", "CityID", "dbo.Cities");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Plains", "AreaStudyID", "dbo.AreaStudies");
            DropForeignKey("dbo.AreaStudies", "CityID", "dbo.Cities");
            DropIndex("dbo.WellVisiteds", new[] { "VisitExpertID" });
            DropIndex("dbo.WellVisiteds", new[] { "WellProfileID" });
            DropIndex("dbo.WellViolations", new[] { "WellVisitedID" });
            DropIndex("dbo.WellViolationsItems", new[] { "InfractionsWellID" });
            DropIndex("dbo.WellProfiles", new[] { "CityID" });
            DropIndex("dbo.WellProfiles", new[] { "PlainID" });
            DropIndex("dbo.WellProfiles", new[] { "StudyAreaID" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Plains", new[] { "AreaStudyID" });
            DropIndex("dbo.AreaStudies", new[] { "CityID" });
            DropTable("dbo.WellVisiteds");
            DropTable("dbo.WellViolations");
            DropTable("dbo.WellViolationsItems");
            DropTable("dbo.WellProfiles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Plains");
            DropTable("dbo.OtherTypes");
            DropTable("dbo.InspectionDepartments");
            DropTable("dbo.Cities");
            DropTable("dbo.AreaStudies");
        }
    }
}
