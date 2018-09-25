using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Http;
using WaterResource.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WaterResource.Controllers
{
    public class MetaDataController : ApiController
    {
        // GET: api/metaData

       //[Authorize]
        public IQueryable<MetaData> GetMetaData(int id)
        {
            List<MetaData> lst = new List<MetaData>();
            PropertyInfo[] propertyInfos = null;

            switch (id)
            {
                case 1:
                    propertyInfos = typeof(WellProfile).GetProperties();
                    break;
                case 2:
                    propertyInfos = typeof(WellVisited).GetProperties();
                    break;
                case 3:
                    propertyInfos = typeof(WellViolation).GetProperties();
                    break;
                case 4:
                    propertyInfos = typeof(WellViolationItems).GetProperties();
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



            // write property names
            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                var d = propertyInfo.GetCustomAttributes(typeof(DisplayNameAttribute), true);
                var r = propertyInfo.CustomAttributes.Where(a => a.AttributeType.Name == "RequiredAttribute");

                lst.Add(new MetaData()
                {
                    Name = propertyInfo.Name,
                    DisplayName = d.Length > 0 ? d.Cast<DisplayNameAttribute>().Single().DisplayName : propertyInfo.Name,
                    Required = r.Count() > 0 ? true : false,
                    Type = propertyInfo.PropertyType.Name
                });

            }

            return lst.AsQueryable<MetaData>();
        }

        public class MetaData
        {
            public string Name { get; set; }
            public string DisplayName { get; set; }
            public string Type { get; set; }
            public bool Required { get; set; }
        }
    }
}

