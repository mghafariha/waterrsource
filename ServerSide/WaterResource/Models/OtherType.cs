using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WaterResource.Models
{
    public class OtherType
    {
        public int ID { get; set; }
        public string ClassName { get; set; }
        public string FieldName { get; set; }
        public string Type { get; set; }
        public string Options { get; set; }
        public bool IsMultiple { get; set; }
        public string TitleField { get; set; }
    }
}