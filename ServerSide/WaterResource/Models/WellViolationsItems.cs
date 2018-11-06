using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WaterResource.Models
{
    public class WellViolationsItems
    {
        public int ID { get; set; }


        [DisplayName("تخلف چاه")]
        public int InfractionsWellID{ get; set; }
        public WellViolation InfractionsWell { get; set; }

        [DisplayName("نوع تخلف")]
       
        public string TypeViolation { get; set; }

        [DisplayName("مقدار")]
        public decimal Amount { get; set; }

        [DisplayName("فایل پیوست")]
        
        public string Attachment { get; set; }

        [DisplayName("توضیحات")]
        public string Description { get; set; }

        [DisplayName("دستور دادستانی")]
        
        public string RecipeProsecutor { get; set; }


        [DisplayName("فایل حکم  دادستان")]
        
        public string FileViolation { get; set; }

        [DisplayName("تاریخ صدور دستور ")]
        
        public DateTime? DateViolation { get; set; }

        [DisplayName("فایل تنظیم شکواییه")]
        
        public string MeetingFile { get; set; }

        [DisplayName("تاریخ تنظیم شکواییه")]
        
        public DateTime? DateFile { get; set; }

        [DisplayName("حکم دادگاه")]
        
        public string CourtJudgment { get; set; }

        [DisplayName("تاریخ بررسی کارشناسی مجدد")]
        
        public DateTime? DateMasters { get; set; }

        [DisplayName("فایل های بررسی کارشناسی مجدد")]
        
        public string FileMasters { get; set; }

        [DisplayName("حکم دادگاه2")]
        
        public string CourtJudgment2 { get; set; }

        [DisplayName("فایل های حکم دادگاه2")]
        
        public string FileCourtJudgment2 { get; set; }

        [DisplayName("تاریخ اجرای حکم")]
        
        public DateTime? DateEnforcement { get; set; }

        [DisplayName("فایل های اجرای حکم")]
        
        public string ExecutionFiles { get; set; }
    }
}