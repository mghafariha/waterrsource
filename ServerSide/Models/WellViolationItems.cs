using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WaterResource.Models
{
    public class WellViolationItems
    {
        public int ID { get; set; }


        [DisplayName("تخلف چاه")]
        [Required]
        public int InfractionsWell { get; set; }

        [DisplayName("نوع تخلف")]
        [Required]
        public string TypeViolation { get; set; }

        [DisplayName("مقدار")]
        public decimal Amount { get; set; }

        [DisplayName("فایل پیوست")]
        [Required]
        public string Attachment { get; set; }

        [DisplayName("توضیحات")]
        public string Description { get; set; }

        [DisplayName("دستور دادستانی")]
        [Required]
        public string RecipeProsecutor { get; set; }


        [DisplayName("فایل حکم  دادستان")]
        [Required]
        public string FileViolation { get; set; }

        [DisplayName("تاریخ صدور دستور ")]
        [Required]
        public DateTime DateViolation { get; set; }

        [DisplayName("فایل تنظیم شکواییه")]
        [Required]
        public string MeetingFile { get; set; }

        [DisplayName("تاریخ تنظیم شکواییه")]
        [Required]
        public DateTime DateFile { get; set; }

        [DisplayName("حکم دادگاه")]
        [Required]
        public string CourtJudgment { get; set; }

        [DisplayName("تاریخ بررسی کارشناسی مجدد")]
        [Required]
        public DateTime DateMasters { get; set; }

        [DisplayName("فایل های بررسی کارشناسی مجدد")]
        [Required]
        public string FileMasters { get; set; }

        [DisplayName("حکم دادگاه2")]
        [Required]
        public string CourtJudgment2 { get; set; }

        [DisplayName("فایل های حکم دادگاه2")]
        [Required]
        public string FileCourtJudgment2 { get; set; }

        [DisplayName("تاریخ اجرای حکم")]
        [Required]
        public DateTime DateEnforcement { get; set; }

        [DisplayName("فایل های اجرای حکم")]
        [Required]
        public string ExecutionFiles { get; set; }
    }
}