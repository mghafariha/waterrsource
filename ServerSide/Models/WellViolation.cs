using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WaterResource.Models
{
    public class WellViolation
    {
        public int ID { get; set; }


        [DisplayName("تاریخ اخطار اول")]
        [Required]
        public DateTime DateFirstWarning { get; set; }

        [DisplayName("مهلت مراجعه اول")]
        [Required]
        public string DeadlineReferralFirstWarning { get; set; }

        [DisplayName("فایل اخطار اول")]
        [Required]
        public string FileFirstWarning { get; set; }

        [DisplayName("تاریخ اخطار دوم")]
        [Required]
        public DateTime SecondWarningDate { get; set; }

        [DisplayName("مهلت مراجعه دوم")]
        [Required]
        public string DeadlineReferralSecondWarning { get; set; }

        [DisplayName("فایل اخطار دوم")]
        [Required]
        public string FileSecondWarning { get; set; }

        [DisplayName("فایل بررسی کارشناسی")]
        [Required]
        public string CheckFile { get; set; }

        [DisplayName("وضعیت چاه")]
        [Required]
        public string WellPosition { get; set; }

        //محاسباتی توسط سیستم
        [DisplayName("تعداد تخلفات")]
        [Required]
        public int NumberInFraction { get; set; }

        [DisplayName("نوع تخلف")]
        [Required]
        public string Violations { get; set; }

        [DisplayName("فایل مختومه ")]
        [Required]
        public string FileClosed { get; set; }

        [DisplayName("تاریخ مختومه شدن")]
        [Required]
        public DateTime DateClosed { get; set; }

        [DisplayName("فایل های میزان صرفه جویی")]
        [Required]
        public string SavingFiles { get; set; }

        [DisplayName("میزان صرفه جویی (هزارمترمکعب)")]
        [Required]
        public decimal SavingAmount { get; set; }

        [DisplayName("نتیجه اقدامات قانونی")]
        [Required]
        public string ResultActions { get; set; }
        //توسط سیستم پر می شود
        [DisplayName("وضعیت")]
        [Required]
        public string Status { get; set; }

        [DisplayName("توضیحات")]
        [Required]
        public string Description { get; set; }

    }
}