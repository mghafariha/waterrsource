using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WaterResource.Models
{
    public class WellVisited
    {
        public int ID { get; set; }
        //public bool InArea { get; set; }
        public string LongitudeWell { get; set; }
        public string LatitudeWell { get; set; }
        public DateTime DateCensus { get; set; }
        public string OwnerCode { get; set; }
        public string OwnerMobile { get; set; }

        public string ElectricityCode { get; set; }
        public string SerialNumberMeter { get; set; }
        public string SerialNumberModem { get; set; }
        public string ManufacturerMeter { get; set; }
        public DateTime DateInstallationMeter { get; set; }
        public string TypeMeter { get; set; }
        public string NumberMeters { get; set; }
        public string WaterSystem { get; set; }
        public decimal ApprovedVolume { get; set; }
        public decimal WorkHours { get; set; }
        public string WaterMeasurementMethod { get; set; }
        public decimal EC { get; set; }
        public decimal DEBI { get; set; }
        public string PresentSituation { get; set; }
        public decimal DiameterWaterPipe { get; set; }
        public int YearDig { get; set; }
        public decimal PowerlevelElectricity { get; set; }
        public decimal PowerlevelDiesel { get; set; }
        public string ArtifactsType { get; set; }
        public decimal AreaUnderCultivation { get; set; }
        public string CultivarType { get; set; }
        public string KindConsumptionWater { get; set; }
        public string Pipeline { get; set; }
        public decimal WellDepth { get; set; }
        public decimal WaterSurface { get; set; }


    }
}