using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WaterResource.Models
{
    public class WellVisited
    {
        public int ID { get; set; }


        [DisplayName("شماره پرونده")]
        public int WellProfileID { get; set; }
        public virtual WellProfile WellProfile { get; set; }

        [DisplayName("وضعیت فعلی چاه")]
        
        public string PresentSituation { get; set; }

        [DisplayName("در محدوده هست")]
        
        public string InArea { get; set; }

        [DisplayName("شماره ملی مالک")]
        public string NationalNumber { get; set; }


        [DisplayName("تلفن همراه مالک")]
        public int Mobile { get; set; }

        [DisplayName("شماره اشتراک برق")]
        
        public string SubscriptionElectricity { get; set; }

        [DisplayName("شماره سریال پلمپ کنتور")]
        
        public string SerialNumberMeter { get; set; }

        [DisplayName("شماره سریال مودم")]
        
        public string SerialNumberModem { get; set; }

        [DisplayName("شرکت سازنده کنتور")]
        public string ManufacturerMeter { get; set; }

        [DisplayName("تاریخ نصب کنتور")]
        public DateTime? DateInstallationMeter { get; set; }

        [DisplayName("نوع کنتور")]
        
        public string TypeMeter { get; set; }

        [DisplayName("کنتور")]
        
        public string Meter { get; set; }

        [DisplayName("عدد کنتور")]
        
        public decimal NumberMeters { get; set; }

        [DisplayName("سیستم آبیاری")]
        
        public string WaterSystem { get; set; }

        [DisplayName("حجم مجاز برداشت")]
       
        public decimal ApprovedVolume { get; set; }

        [DisplayName("ساعت کارکرد سالانه")]
        
        public decimal WorkHours { get; set; }

        [DisplayName("روش اندازه گیری آبدهی")]
        
        public string WaterMeasurementMethod { get; set; }

        [DisplayName("هدایت الکتریکی")]
        
        public decimal EC { get; set; }

        [DisplayName("دبی (لیتر در تانیه)")]
        
        public decimal FlowWater { get; set; }

        [DisplayName("قطر لوله آبده (اینچ)")]
       
        public decimal DiameterWaterPipe { get; set; }

        [DisplayName("سال حفر")]
        
        public int YearDig { get; set; }

        [DisplayName("میزان قدرت برق")]
        
        public decimal PowerlevelElectricity { get; set; }

        [DisplayName("میزان قدرت دیزل")]
        
        public decimal PowerlevelDiesel { get; set; }

        [DisplayName("نوع منصوبات")]
        
        public string ArtifactsType { get; set; }

        [DisplayName("سطح زیر کشت(هکتار)")]
        
        public decimal AreaUnderCultivation { get; set; }

        [DisplayName("نوع کشت")]
       
        public string CultivarType { get; set; }

        [DisplayName("نوع مصرف آب")]
       
        public string KindConsumptionWater { get; set; }

        [DisplayName("لوله جدار")]
        
        public string Pipeline { get; set; }

        [DisplayName("عمق چاه (متر)")]
       
        public decimal WellDepth { get; set; }

        [DisplayName("سطح آب(متر)")]
        
        public decimal WaterSurface { get; set; }

        [DisplayName("طول جغرافیایی")]
        
        public decimal LongitudeWell { get; set; }

        [DisplayName("عرض جغرافیایی")]
        
        public decimal LatitudeWell { get; set; }

        [DisplayName("تاریخ آمار برداری")]
        
        public DateTime? DateCensus { get; set; }

        [DisplayName("کارشناس بازدید")]
        public int VisitExpertID { get; set; }
        public virtual InspectionDepartments VisitExpert { get; set; }

        // اتوماتیک توسط سیستم
        [DisplayName("وضعیت")]
        public string Status { get; set; }

        // اتوماتیک توسط سیستم
        [DisplayName("تاریخ ثبت")]
        public DateTime? DateRegistration { get; set; }

        // اتوماتیک توسط سیستم
        [DisplayName("تاریخ تایید مدیر ناحیه")]
        public DateTime? DistrictAdministratorApprovalDate { get; set; }

        // اتوماتیک توسط سیستم 
        [DisplayName("تاریخ تایید آب منطقه ایی")]
        public DateTime? RegionalWaterCertificateApprovalDate { get; set; }

        //[DisplayName("شناسه کاریز")]
        
        //public string KaraisID { get; set; }

        [DisplayName("کد پستی مالک")]
        public decimal OwnerPostalCode { get; set; }

        [DisplayName("روستا ")]
        
        public string Village { get; set; }

        [DisplayName("زون")]
        
        public decimal zone { get; set; }

        [DisplayName("نوع چاه")]
        
        public string TypeWell { get; set; }

        //[DisplayName("محدوده مطالعاتی")]
        //public int AreaStudyID { get; set; }
        //public virtual AreaStudy StudyArea { get; set; }

        //[DisplayName("نام دشت")]
        //public int PlainID { get; set; }
        //public virtual Plain Plain { get; set; }

        [DisplayName("تعداد شرکا")]
        public int NumberPartners { get; set; }

        [DisplayName("وضعیت کنتور")]
        
        public string StatusMeter { get; set; }

        [DisplayName("وسیله حفاری")]
        public string DrillingDevice { get; set; }

        [DisplayName("نوع حفر")]
        
        public string TypeDigging { get; set; }

        [DisplayName("پروانه حفر")]
        
        public string licenseDig { get; set; }

        [DisplayName("پروانه بهره برداری")]
        
        public string licenseUse { get; set; }

        [DisplayName("تمدید پروانه بهره برداری")]
        
        public string ExtendedlicenseUse { get; set; }

        [DisplayName("سابقه انسداد")]
        
        public string BackgroundObstruction { get; set; }

        [DisplayName("تغییر نوع مصرف")]
        
        public string ChangeTypeUse { get; set; }

        [DisplayName("کف شکنی غیر مجاز")]
        
        public string FloorBreakerillegal { get; set; }

        [DisplayName("انتقال آب")]
        
        public string TransferWate { get; set; }

        [DisplayName("اضافه برداشت")]
        
        public string AddedExtraction { get; set; }

        [DisplayName("میزان اضافه برداشت(حجم به مترمکعب)")]
        
        public decimal RateAddedExtraction { get; set; }

        [DisplayName("جابه جایی غیرمجاز چاه")]
        
        public string Displacementillegal { get; set; }

        [DisplayName("میزان جابجایی(متر)")]
        
        public decimal DisplacementRate { get; set; }

        [DisplayName("منصوبات غیر مجاز")]
        
        public string Artifactsillegal { get; set; }

        [DisplayName("آب فروشی")]
        
        public string WaterSupply { get; set; }

        [DisplayName("آبشیرین کن غیرمجاز")]
       
        public string Desalinationillegal { get; set; }

        [DisplayName("سایر تخلفات ")]
       
        public string OtherViolations { get; set; }

        [DisplayName("تصاویر")]
        
        public string Pictures { get; set; }

        [DisplayName("توضیحات")]
        public string Description { get; set; }

    }
}