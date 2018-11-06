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
       
        public decimal ApprovedVolume { get; set; }

        [DisplayName("ساعت کارکرد سالانه")]
        
        public decimal WorkHours { get; set; }

        [DisplayName("دبی")]
        
        public decimal FlowWater { get; set; }

        [DisplayName("لوله آبده (اینچ)")]
       
        public decimal DiameterWaterPipe { get; set; }

        [DisplayName("میزان قدرت(برق)")]
        
        public decimal PowerlevelElectricity { get; set; }

        [DisplayName("میزان قدرت (دیزل)")]
       
        public decimal PowerlevelDiesel { get; set; }

        [DisplayName("میزان اراضی(هکتار)")]
      
        public decimal LandArea { get; set; }

        [DisplayName("نوع مصرف آب")]
        
        public string KindConsumptionWater { get; set; }

        [DisplayName("لوله جدار")]
        
        public string Pipeline { get; set; }

        [DisplayName("عمق چاه(متر)")]
        [Required]
        public decimal WellDepth { get; set; }

        [DisplayName("سطح آب(متر)")]
        
        public decimal WaterSurface { get; set; }

        [DisplayName("طول جغرافیایی")]
       
        public decimal LongitudeWell { get; set; }

        [DisplayName("عرض جغرافیایی")]
        
        public decimal LatitudeWell { get; set; }

        [DisplayName("نوع پروانه")]
       
        public string licenseKind { get; set; }

        [DisplayName("شماره پروانه بهره برداری")]
      
        public string licenseNumber { get; set; }

        [DisplayName("تاریخ پروانه بهره برداری")]
      
        public DateTime? licenseDate { get; set; }

        [DisplayName("شماره پروانه حفر اولیه")]
        
        public string licenseNumberDigPrimary { get; set; }

        [DisplayName("تاریخ پروانه حفر اولیه")]
        
        public DateTime? licenseDateDigPrimary { get; set; }

        [DisplayName("نوع مجوز")]
        
        public string Typelicense { get; set; }

        [DisplayName("نام روستا")]
      
        public string Village { get; set; }

        [DisplayName("محدوده مطالعاتی")]
         public int StudyAreaID { get; set; }
        public virtual AreaStudy StudyArea { get; set; }
       

        [DisplayName("دشت")]
          public int PlainID { get; set; }
         public virtual Plain Plain { get; set; }

        [DisplayName("نام مالک")]
       
        public string OwnerName { get; set; }

        [DisplayName("نام پدر")]
        public string fathersName { get; set; }

        [DisplayName("تعداد شرکا")]
        public int NumberPartners { get; set; }

        [DisplayName("شماره پرونده")]
        
        public string Index { get; set; }

        [DisplayName("شماره مسلسل")]
        
        public string SerialNumber { get; set; }

        [DisplayName("نوع فرم تعین تکلیف")]
       
        public string FormType { get; set; }

        [DisplayName("کد اشتراک ساماب")]
        
        public string SubscriptionCode { get; set; }

        [DisplayName("زون")]
        
        public decimal zone { get; set; }

        [DisplayName("نوع چاه")]
        
        public string TypeWell { get; set; }

        [DisplayName("کد مشترک ")]
        public string CodeConservationStudies { get; set; }

        [DisplayName("سیستم آبیاری")]
        
        public string WaterSystem { get; set; }

        [DisplayName("شهرستان")]
        public int CityID { get; set; }
        public virtual City City { get; set; }
        [DisplayName("کنتور")]
        
        public string Meter { get; set; }

        [DisplayName("تاریخ نصب کنتور")]
        public DateTime DateInstallationMeter { get; set; }

        [DisplayName("امور آب ")]
        
        public string WaterAffairs { get; set; }

        [DisplayName("وسیله حفاری")]
        public string DrillingDevice { get; set; }

        [DisplayName("نوع حفر")]
        public string TypeDigging { get; set; }

        [DisplayName("نوع کشت")]
    
        public string CultivarType { get; set; }

        [DisplayName("نوع منصوبات")]
        
        public string ArtifactsType { get; set; }

        [DisplayName("کد ملی مالک")]
        public string NationalNumber { get; set; }

        [DisplayName("مجوز کف شکنی")]
        
        public string LicenseFloorBreaker { get; set; }

        [DisplayName("میزان مجاز کف شکنی(متر)")]
        
        public decimal AllowanceFloorBreaker { get; set; }

        [DisplayName("مجوز جابه جایی")]
       
        public string DisplacemenLicense { get; set; }

        [DisplayName("آخرین مجوز جابه جایی")]
        
        public DateTime? finalDisplacemenLicense { get; set; }

        [DisplayName("میزان جابه جایی (متر)")]
      
        public decimal DisplacementRate { get; set; }

        [DisplayName("سابقه انسداد")]
       
        public string BackgroundObstruction { get; set; }

       

        [DisplayName("هدایت الکتریکی")]
        [Required]
        public decimal EC { get; set; }
        [DisplayName("توضیحات")]
        public string Description { get; set; }


    }
}