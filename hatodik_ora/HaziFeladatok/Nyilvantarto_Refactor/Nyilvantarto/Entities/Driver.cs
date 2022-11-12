using System;
using System.Collections.Generic;
using System.Text;

namespace Nyilvantarto.Entities
{
    public class Driver : Person
    {
        public List<DrivingLicense> DrivingLicenses { get; set; }

        public Driver(string name, DateTime date) : base(name, date)
        {
        }
    }
}
