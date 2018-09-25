namespace WaterResource.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
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
                        KindConsumptionWater = c.String(nullable: false),
                        Pipeline = c.String(nullable: false),
                        WellDepth = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WaterSurface = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LongitudeWell = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LatitudeWell = c.Decimal(nullable: false, precision: 18, scale: 2),
                        licenseKind = c.String(nullable: false),
                        licenseNumber = c.String(nullable: false),
                        licenseDate = c.DateTime(nullable: false),
                        licenseNumberDigPrimary = c.String(nullable: false),
                        licenseDateDigPrimary = c.DateTime(nullable: false),
                        Typelicense = c.String(nullable: false),
                        Village = c.String(nullable: false),
                        StudyArea = c.Int(nullable: false),
                        Plain = c.Int(nullable: false),
                        OwnerName = c.String(nullable: false),
                        fathersName = c.String(),
                        NumberPartners = c.Int(nullable: false),
                        Index = c.String(nullable: false),
                        SerialNumber = c.String(nullable: false),
                        FormType = c.String(nullable: false),
                        SubscriptionCode = c.String(nullable: false),
                        zone = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TypeWell = c.String(nullable: false),
                        CodeConservationStudies = c.String(),
                        WaterSystem = c.String(nullable: false),
                        City = c.Int(nullable: false),
                        Meter = c.String(nullable: false),
                        DateInstallationMeter = c.DateTime(nullable: false),
                        WaterAffairs = c.String(nullable: false),
                        DrillingDevice = c.String(),
                        TypeDigging = c.String(),
                        CultivarType = c.String(nullable: false),
                        ArtifactsType = c.String(nullable: false),
                        NationalNumber = c.String(),
                        LicenseFloorBreaker = c.String(nullable: false),
                        AllowanceFloorBreaker = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DisplacemenLicense = c.String(nullable: false),
                        finalDisplacemenLicense = c.DateTime(nullable: false),
                        DisplacementRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BackgroundObstruction = c.String(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.WellViolationItems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        InfractionsWell = c.Int(nullable: false),
                        TypeViolation = c.String(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Attachment = c.String(nullable: false),
                        Description = c.String(),
                        RecipeProsecutor = c.String(nullable: false),
                        FileViolation = c.String(nullable: false),
                        DateViolation = c.DateTime(nullable: false),
                        MeetingFile = c.String(nullable: false),
                        DateFile = c.DateTime(nullable: false),
                        CourtJudgment = c.String(nullable: false),
                        DateMasters = c.DateTime(nullable: false),
                        FileMasters = c.String(nullable: false),
                        CourtJudgment2 = c.String(nullable: false),
                        FileCourtJudgment2 = c.String(nullable: false),
                        DateEnforcement = c.DateTime(nullable: false),
                        ExecutionFiles = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.WellViolations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DateFirstWarning = c.DateTime(nullable: false),
                        DeadlineReferralFirstWarning = c.String(nullable: false),
                        FileFirstWarning = c.String(nullable: false),
                        SecondWarningDate = c.DateTime(nullable: false),
                        DeadlineReferralSecondWarning = c.String(nullable: false),
                        FileSecondWarning = c.String(nullable: false),
                        CheckFile = c.String(nullable: false),
                        WellPosition = c.String(nullable: false),
                        NumberInFraction = c.Int(nullable: false),
                        Violations = c.String(nullable: false),
                        FileClosed = c.String(nullable: false),
                        DateClosed = c.DateTime(nullable: false),
                        SavingFiles = c.String(nullable: false),
                        SavingAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ResultActions = c.String(nullable: false),
                        Status = c.String(nullable: false),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.WellVisiteds",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Index = c.Int(nullable: false),
                        PresentSituation = c.String(nullable: false),
                        InArea = c.String(nullable: false),
                        NationalNumber = c.String(),
                        Mobile = c.Int(nullable: false),
                        SubscriptionElectricity = c.String(nullable: false),
                        SerialNumberMeter = c.String(nullable: false),
                        SerialNumberModem = c.String(nullable: false),
                        ManufacturerMeter = c.String(),
                        DateInstallationMeter = c.DateTime(nullable: false),
                        TypeMeter = c.String(nullable: false),
                        Meter = c.String(nullable: false),
                        NumberMeters = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WaterSystem = c.String(nullable: false),
                        ApprovedVolume = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WorkHours = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WaterMeasurementMethod = c.String(nullable: false),
                        EC = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FlowWater = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiameterWaterPipe = c.Decimal(nullable: false, precision: 18, scale: 2),
                        YearDig = c.Int(nullable: false),
                        PowerlevelElectricity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PowerlevelDiesel = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ArtifactsType = c.String(nullable: false),
                        AreaUnderCultivation = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CultivarType = c.String(nullable: false),
                        KindConsumptionWater = c.String(nullable: false),
                        Pipeline = c.String(nullable: false),
                        WellDepth = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WaterSurface = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LongitudeWell = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LatitudeWell = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DateCensus = c.DateTime(nullable: false),
                        VisitExpert = c.Int(nullable: false),
                        Status = c.String(),
                        DateRegistration = c.DateTime(nullable: false),
                        DistrictAdministratorApprovalDate = c.DateTime(nullable: false),
                        RegionalWaterCertificateApprovalDate = c.DateTime(nullable: false),
                        KaraisID = c.String(nullable: false),
                        OwnerPostalCode = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Village = c.String(nullable: false),
                        zone = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TypeWell = c.String(nullable: false),
                        StudyArea = c.Int(nullable: false),
                        Plain = c.Int(nullable: false),
                        NumberPartners = c.Int(nullable: false),
                        StatusMeter = c.String(nullable: false),
                        DrillingDevice = c.String(),
                        TypeDigging = c.String(nullable: false),
                        licenseDig = c.String(nullable: false),
                        licenseUse = c.String(nullable: false),
                        ExtendedlicenseUse = c.String(nullable: false),
                        BackgroundObstruction = c.String(nullable: false),
                        ChangeTypeUse = c.String(nullable: false),
                        FloorBreakerillegal = c.String(nullable: false),
                        TransferWate = c.String(nullable: false),
                        AddedExtraction = c.String(nullable: false),
                        RateAddedExtraction = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Displacementillegal = c.String(nullable: false),
                        DisplacementRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Artifactsillegal = c.String(nullable: false),
                        WaterSupply = c.String(nullable: false),
                        Desalinationillegal = c.String(nullable: false),
                        OtherViolations = c.String(nullable: false),
                        Pictures = c.String(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropTable("dbo.WellVisiteds");
            DropTable("dbo.WellViolations");
            DropTable("dbo.WellViolationItems");
            DropTable("dbo.WellProfiles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
        }
    }
}
