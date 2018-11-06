using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WaterResource.Models
{
    public class City
    {
        public int ID { get; set; }

        [DisplayName("نام")]
        [Required]
        public string Title { get; set; }

        [DisplayName("کارشناس امور")]
        [Required]
        public Guid OmorExpert { get; set; }

        [DisplayName("مدیر ناحیه")]
        [Required]
        public Guid AreaManager { get; set; }

        [DisplayName("کارشناس حقوقی")]
        [Required]
        public Guid LegalExpert { get; set; }
    }
}