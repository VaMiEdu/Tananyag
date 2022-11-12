using System;
using System.Collections.Generic;
using System.Text;

namespace Nyilvantarto.Entities
{
    public enum DrivingLicenseType { Car, Ship, Bus }

    public class DrivingLicense
    {
        public DrivingLicenseType DrivingLicenseType { get; set; }
        public string Id  { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
