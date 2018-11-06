using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Http;
using WaterResource.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Web;
using System.IO;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;

namespace WaterResource.Controllers
{
    public class MetaDataController : ApiController
    {
        // GET: api/metaData
        private ApplicationDbContext db = new ApplicationDbContext();
        //[Authorize]
        public IQueryable<MetaData> GetMetaData(int id)
        {
            List<MetaData> lst = new List<MetaData>();
            PropertyInfo[] propertyInfos = null;
            string cName = "";
            switch (id)
            {
                case 1:
                    propertyInfos = typeof(WellProfile).GetProperties();
                    cName = "WellProfile";
                    break;
                case 2:
                    propertyInfos = typeof(WellVisited).GetProperties();
                    cName = "WellVisited";
                    break;
                case 3:
                    propertyInfos = typeof(WellViolation).GetProperties();
                    cName = "WellViolation";
                    break;
                case 4:
                    propertyInfos = typeof(WellViolationsItems).GetProperties();
                    cName = "WellViolationItems";
                    break;
                //case 5:
                //    propertyInfos = typeof(WellProfile).GetProperties();
                //    break;
                //case 6:
                //    propertyInfos = typeof(WellProfile).GetProperties();
                //    break;
                default:
                    break;
            }

            List<OtherType> others = db.OtherType.Where(a => a.ClassName == cName).ToList();

            // write property names
            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                if (propertyInfo.GetMethod.IsVirtual == false)
                {


                    var d = propertyInfo.GetCustomAttributes(typeof(DisplayNameAttribute), true);
                    var r = propertyInfo.CustomAttributes.Where(a => a.AttributeType.Name == "RequiredAttribute");
                    var o = others.Where(a => a.FieldName == propertyInfo.Name);
                    if (o.Count() > 0)
                        lst.Add(new MetaData()
                        {
                            Name = propertyInfo.Name,
                            DisplayName = d.Length > 0 ? d.Cast<DisplayNameAttribute>().Single().DisplayName : propertyInfo.Name,
                            Required = r.Count() > 0 ? true : false,
                            Type = o.FirstOrDefault().Type,
                            Options = o.FirstOrDefault().Options,
                            IsMulti = o.FirstOrDefault().IsMultiple,
                            TitleField = o.FirstOrDefault().TitleField
                        });
                    else
                        lst.Add(new MetaData()
                        {
                            Name = propertyInfo.Name,
                            DisplayName = d.Length > 0 ? d.Cast<DisplayNameAttribute>().Single().DisplayName : propertyInfo.Name,
                            Required = r.Count() > 0 ? true : false,
                            Type = propertyInfo.PropertyType.Name.IndexOf("Nullable") < 0 ? propertyInfo.PropertyType.Name : propertyInfo.PropertyType.GetGenericArguments()[0].Name
                        });
                }
            }

            return lst.AsQueryable<MetaData>();
        }

        public class MetaData
        {
            public string Name { get; set; }
            public string DisplayName { get; set; }
            public string Type { get; set; }
            public bool Required { get; set; }
            public string Options { get; set; }
            public bool IsMulti { get; set; }
            public string TitleField { get; set; }
        }
        public class attachment
        {
            public string url { get; set; }
            public string name { get; set; }
            public string description { get; set; }

        }

    }
}


