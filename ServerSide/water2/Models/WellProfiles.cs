using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Water2.Models
{
    public class WellProfiles
    {
        public int ID { get; set; }
        //پرونده
        public string FormType { get; set; }
        public string SerialNumber { get; set; }
        public string Index { get; set; }

        public string OwnerName { get; set; }
        public string FathersName { get; set; }
        public int NumberPartners { get; set; }
       
        public string Plain { get; set; }
        public string StudyArea { get; set; }
        public string Village { get; set; }
        public string LatitudeWell { get; set; }
        public string LongitudeWell { get; set; }

        public string TypeLicense { get; set; }
        public string LicenseDateDig { get; set; }
        public string LicenseNumberDig { get; set; }
        public DateTime LicenseDate { get; set; }
        public string LicenseNumber { get; set; }
        public string LicenseKind { get; set; }
     
        public decimal WaterSurface { get; set; }
        public decimal WellDepth { get; set; }
        public string Pipeline { get; set; }
        public string KindConsumptionWater { get; set; }
        public decimal LandArea { get; set; }
        public decimal PowerlevelDiesel { get; set; }
        public decimal PowerlevelElectricity { get; set; }
        public decimal DiameterWaterPipe { get; set; }
        public decimal FlowWater { get; set; }
        public decimal WorkHours { get; set; }
        //public string OtherViolations { get; set; }
        //public string FloorBreaker { get; set; }
        //public string ArtifactsUnallowed { get; set; }
        //public string TransferringWater { get; set; }
        //public string WaterExtraction { get; set; }
        //public string ChangeConsommer { get; set; }
        //public string VendreWater { get; set; }
        //public string Changelocation { get; set; }
        public decimal ApprovedVolume { get; set; }

    }
}