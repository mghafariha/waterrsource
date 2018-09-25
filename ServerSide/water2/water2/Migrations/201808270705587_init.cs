namespace water2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WellProfiles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FormType = c.String(),
                        SerialNumber = c.String(),
                        Index = c.String(),
                        OwnerName = c.String(),
                        FathersName = c.String(),
                        NumberPartners = c.Int(nullable: false),
                        Plain = c.String(),
                        StudyArea = c.String(),
                        Village = c.String(),
                        LatitudeWell = c.String(),
                        LongitudeWell = c.String(),
                        TypeLicense = c.String(),
                        LicenseDateDig = c.String(),
                        LicenseNumberDig = c.String(),
                        LicenseDate = c.DateTime(nullable: false),
                        LicenseNumber = c.String(),
                        LicenseKind = c.String(),
                        WaterSurface = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WellDepth = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Pipeline = c.String(),
                        KindConsumptionWater = c.String(),
                        LandArea = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PowerlevelDiesel = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PowerlevelElectricity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiameterWaterPipe = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FlowWater = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WorkHours = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ApprovedVolume = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.WellVisiteds",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LongitudeWell = c.String(),
                        LatitudeWell = c.String(),
                        DateCensus = c.DateTime(nullable: false),
                        OwnerCode = c.String(),
                        OwnerMobile = c.String(),
                        ElectricityCode = c.String(),
                        SerialNumberMeter = c.String(),
                        SerialNumberModem = c.String(),
                        ManufacturerMeter = c.String(),
                        DateInstallationMeter = c.DateTime(nullable: false),
                        TypeMeter = c.String(),
                        NumberMeters = c.String(),
                        WaterSystem = c.String(),
                        ApprovedVolume = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WorkHours = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WaterMeasurementMethod = c.String(),
                        EC = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DEBI = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PresentSituation = c.String(),
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
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WellVisiteds");
            DropTable("dbo.WellProfiles");
        }
    }
}
