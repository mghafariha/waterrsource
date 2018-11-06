using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace WaterResource.Models
{
    public class InspectionDepartments
    {
        public int ID { get; set; }


        [DisplayName("شماره شرکت")]
        [Required]
        public int Index { get; set; }

    }
}