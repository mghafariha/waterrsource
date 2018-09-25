using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WaterResource.Models
{
    public class WellProfile
    {
        //decimal ==> عدد
        //int ==> عدد ساده - انتخابی لوک آپ
        //string ==> یه خط متن - چند خط متن - فایل- انتخابی آیتم دار
        //DateTime ==>


        // نام فارسی - تایپ - الزامی
        public int ID { get; set; }

        [DisplayName("حجم مجاز برداشت")]
        [Required]
        public decimal ApprovedVolume { get; set; }

        [DisplayName("ساعت کارکرد سالانه")]
        [Required]
        public decimal WorkHours { get; set; }

        [DisplayName("دبی")]
        [Required]
        public decimal FlowWater { get; set; }

        [DisplayName("لوله آبده (اینچ)")]
        [Required]
        public decimal DiameterWaterPipe { get; set; }

        [DisplayName("میزان قدرت(برق)")]
        [Required]
        public decimal PowerlevelElectricity { get; set; }

        [DisplayName("میزان قدرت (دیزل)")]
        [Required]
        public decimal PowerlevelDiesel { get; set; }

        [DisplayName("میزان اراضی(هکتار)")]
        [Required]
        public decimal LandArea { get; set; }

        [DisplayName("نوع مصرف آب")]
        [Required]
        public string KindConsumptionWater { get; set; }

        [DisplayName("لوله جدار")]
        [Required]
        public string Pipeline { get; set; }

        [DisplayName("عمق چاه(متر)")]
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

        [DisplayName("نوع پروانه")]
        [Required]
        public string licenseKind { get; set; }

        [DisplayName("شماره پروانه بهره برداری")]
        [Required]
        public string licenseNumber { get; set; }

        [DisplayName("تاریخ پروانه بهره برداری")]
        [Required]
        public DateTime licenseDate { get; set; }

        [DisplayName("شماره پروانه حفر اولیه")]
        [Required]
        public string licenseNumberDigPrimary { get; set; }

        [DisplayName("تاریخ پروانه حفر اولیه")]
        [Required]
        public DateTime licenseDateDigPrimary { get; set; }

        [DisplayName("نوع مجوز")]
        [Required]
        public string Typelicense { get; set; }

        [DisplayName("نام روستا")]
        [Required]
        public string Village { get; set; }

        [DisplayName("محدوده مطالعاتی")]
        [Required]
        public int StudyArea { get; set; }

        [DisplayName("دشت")]
        [Required]
        public int Plain { get; set; }

        [DisplayName("نام مالک")]
        [Required]
        public string OwnerName { get; set; }

        [DisplayName("نام پدر")]
        public string fathersName { get; set; }

        [DisplayName("تعداد شرکا")]
        public int NumberPartners { get; set; }

        [DisplayName("شماره پرونده")]
        [Required]
        public string Index { get; set; }

        [DisplayName("شماره مسلسل")]
        [Required]
        public string SerialNumber { get; set; }

        [DisplayName("نوع فرم تعین تکلیف")]
        [Required]
        public string FormType { get; set; }

        [DisplayName("کد اشتراک ساماب")]
        [Required]
        public string SubscriptionCode { get; set; }

        [DisplayName("زون")]
        [Required]
        public decimal zone { get; set; }

        [DisplayName("نوع چاه")]
        [Required]
        public string TypeWell { get; set; }

        [DisplayName("کد مشترک ")]
        public string CodeConservationStudies { get; set; }

        [DisplayName("سیستم آبیاری")]
        [Required]
        public string WaterSystem { get; set; }

        [DisplayName("شهرستان")]
        [Required]
        public int City { get; set; }

        [DisplayName("کنتور")]
        [Required]
        public string Meter { get; set; }

        [DisplayName("تاریخ نصب کنتور")]
        public DateTime DateInstallationMeter { get; set; }

        [DisplayName("امور آب ")]
        [Required]
        public string WaterAffairs { get; set; }

        [DisplayName("وسیله حفاری")]
        public string DrillingDevice { get; set; }

        [DisplayName("نوع حفر")]
        public string TypeDigging { get; set; }

        [DisplayName("نوع کشت")]
        [Required]
        public string CultivarType { get; set; }

        [DisplayName("نوع منصوبات")]
        [Required]
        public string ArtifactsType { get; set; }

        [DisplayName("کد ملی مالک")]
        public string NationalNumber { get; set; }

        [DisplayName("مجوز کف شکنی")]
        [Required]
        public string LicenseFloorBreaker { get; set; }

        [DisplayName("میزان مجاز کف شکنی(متر)")]
        [Required]
        public decimal AllowanceFloorBreaker { get; set; }

        [DisplayName("مجوز جابه جایی")]
        [Required]
        public string DisplacemenLicense { get; set; }

        [DisplayName("آخرین مجوز جابه جایی")]
        [Required]
        public DateTime finalDisplacemenLicense { get; set; }

        [DisplayName("میزان جابه جایی (متر)")]
        [Required]
        public decimal DisplacementRate { get; set; }

        [DisplayName("سابقه انسداد")]
        [Required]
        public string BackgroundObstruction { get; set; }

        [DisplayName("توضیحات")]
        public string Description { get; set; }

    }
}