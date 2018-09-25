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
        [Required]
        public int Index { get; set; }

        [DisplayName("وضعیت فعلی چاه")]
        [Required]
        public string PresentSituation { get; set; }

        [DisplayName("در محدوده هست")]
        [Required]
        public string InArea { get; set; }

        [DisplayName("شماره ملی مالک")]
        public string NationalNumber { get; set; }


        [DisplayName("تلفن همراه مالک")]
        public int Mobile { get; set; }

        [DisplayName("شماره اشتراک برق")]
        [Required]
        public string SubscriptionElectricity { get; set; }

        [DisplayName("شماره سریال پلمپ کنتور")]
        [Required]
        public string SerialNumberMeter { get; set; }

        [DisplayName("شماره سریال مودم")]
        [Required]
        public string SerialNumberModem { get; set; }

        [DisplayName("شرکت سازنده کنتور")]
        public string ManufacturerMeter { get; set; }

        [DisplayName("تاریخ نصب کنتور")]
        public DateTime DateInstallationMeter { get; set; }

        [DisplayName("نوع کنتور")]
        [Required]
        public string TypeMeter { get; set; }

        [DisplayName("کنتور")]
        [Required]
        public string Meter { get; set; }

        [DisplayName("عدد کنتور")]
        [Required]
        public decimal NumberMeters { get; set; }

        [DisplayName("سیستم آبیاری")]
        [Required]
        public string WaterSystem { get; set; }

        [DisplayName("حجم مجاز برداشت")]
        [Required]
        public decimal ApprovedVolume { get; set; }

        [DisplayName("ساعت کارکرد سالانه")]
        [Required]
        public decimal WorkHours { get; set; }

        [DisplayName("روش اندازه گیری آبدهی")]
        [Required]
        public string WaterMeasurementMethod { get; set; }

        [DisplayName("هدایت الکتریکی")]
        [Required]
        public decimal EC { get; set; }

        [DisplayName("دبی (لیتر در تانیه)")]
        [Required]
        public decimal FlowWater { get; set; }

        [DisplayName("قطر لوله آبده (اینچ)")]
        [Required]
        public decimal DiameterWaterPipe { get; set; }

        [DisplayName("سال حفر")]
        [Required]
        public int YearDig { get; set; }

        [DisplayName("میزان قدرت برق")]
        [Required]
        public decimal PowerlevelElectricity { get; set; }

        [DisplayName("میزان قدرت دیزل")]
        [Required]
        public decimal PowerlevelDiesel { get; set; }

        [DisplayName("نوع منصوبات")]
        [Required]
        public string ArtifactsType { get; set; }

        [DisplayName("سطح زیر کشت(هکتار)")]
        [Required]
        public decimal AreaUnderCultivation { get; set; }

        [DisplayName("نوع کشت")]
        [Required]
        public string CultivarType { get; set; }

        [DisplayName("نوع مصرف آب")]
        [Required]
        public string KindConsumptionWater { get; set; }

        [DisplayName("لوله جدار")]
        [Required]
        public string Pipeline { get; set; }

        [DisplayName("عمق چاه (متر)")]
        [Required]
        public decimal WellDepth { get; set; }

        [DisplayName("سطح آب(متر)")]
        [Required]
        public decimal WaterSurface { get; set; }

        [DisplayName("طول جغرافیایی")]
        [Required]
        public decimal LongitudeWell { get; set; }

        [DisplayName("عرض جغرافیایی")]
        [Required]
        public decimal LatitudeWell { get; set; }

        [DisplayName("تاریخ آمار برداری")]
        [Required]
        public DateTime DateCensus { get; set; }

        [DisplayName("کارشناس بازدید")]
        [Required]
        public int VisitExpert { get; set; }

        // اتوماتیک توسط سیستم
        [DisplayName("وضعیت")]
        public string Status { get; set; }

        // اتوماتیک توسط سیستم
        [DisplayName("تاریخ ثبت")]
        public DateTime DateRegistration { get; set; }

        // اتوماتیک توسط سیستم
        [DisplayName("تاریخ تایید مدیر ناحیه")]
        public DateTime DistrictAdministratorApprovalDate { get; set; }

        // اتوماتیک توسط سیستم 
        [DisplayName("تاریخ تایید آب منطقه ایی")]
        public DateTime RegionalWaterCertificateApprovalDate { get; set; }

        [DisplayName("شناسه کاریز")]
        [Required]
        public string KaraisID { get; set; }

        [DisplayName("کد پستی مالک")]
        public decimal OwnerPostalCode { get; set; }

        [DisplayName("روستا ")]
        [Required]
        public string Village { get; set; }

        [DisplayName("زون")]
        [Required]
        public decimal zone { get; set; }

        [DisplayName("نوع چاه")]
        [Required]
        public string TypeWell { get; set; }

        [DisplayName("محدوده مطالعاتی")]
        [Required]
        public int StudyArea { get; set; }

        [DisplayName("نام دشت")]
        [Required]
        public int Plain { get; set; }

        [DisplayName("تعداد شرکا")]
        public int NumberPartners { get; set; }

        [DisplayName("وضعیت کنتور")]
        [Required]
        public string StatusMeter { get; set; }

        [DisplayName("وسیله حفاری")]
        public string DrillingDevice { get; set; }

        [DisplayName("نوع حفر")]
        [Required]
        public string TypeDigging { get; set; }

        [DisplayName("پروانه حفر")]
        [Required]
        public string licenseDig { get; set; }

        [DisplayName("پروانه بهره برداری")]
        [Required]
        public string licenseUse { get; set; }

        [DisplayName("تمدید پروانه بهره برداری")]
        [Required]
        public string ExtendedlicenseUse { get; set; }

        [DisplayName("سابقه انسداد")]
        [Required]
        public string BackgroundObstruction { get; set; }

        [DisplayName("تغییر نوع مصرف")]
        [Required]
        public string ChangeTypeUse { get; set; }

        [DisplayName("کف شکنی غیر مجاز")]
        [Required]
        public string FloorBreakerillegal { get; set; }

        [DisplayName("انتقال آب")]
        [Required]
        public string TransferWate { get; set; }

        [DisplayName("اضافه برداشت")]
        [Required]
        public string AddedExtraction { get; set; }

        [DisplayName("میزان اضافه برداشت(حجم به مترمکعب)")]
        [Required]
        public decimal RateAddedExtraction { get; set; }

        [DisplayName("جابه جایی غیرمجاز چاه")]
        [Required]
        public string Displacementillegal { get; set; }

        [DisplayName("میزان جابجایی(متر)")]
        [Required]
        public decimal DisplacementRate { get; set; }

        [DisplayName("منصوبات غیر مجاز")]
        [Required]
        public string Artifactsillegal { get; set; }

        [DisplayName("آب فروشی")]
        [Required]
        public string WaterSupply { get; set; }

        [DisplayName("آبشیرین کن غیرمجاز")]
        [Required]
        public string Desalinationillegal { get; set; }

        [DisplayName("سایر تخلفات ")]
        [Required]
        public string OtherViolations { get; set; }

        [DisplayName("تصاویر")]
        [Required]
        public string Pictures { get; set; }

        [DisplayName("توضیحات")]
        public string Description { get; set; }

    }
}