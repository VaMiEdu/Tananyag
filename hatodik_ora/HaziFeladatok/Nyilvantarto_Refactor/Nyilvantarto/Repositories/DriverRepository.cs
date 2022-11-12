using Nyilvantarto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nyilvantarto.Repositories
{
    public class DriverRepository : IRepository<Driver>
    {
        private List<Driver> Drivers { get; set; } = new List<Driver>();

        public bool Add(Driver driver)
        {
            if (Drivers.Any(x => x.Name.Equals(driver.Name)))
            {
                return false;
            }

            Drivers.Add(driver);
            return true;
        }

        public List<Driver> Get()
        {
            return Drivers;
        }

        public Driver GetByName(string name)
        {
            return Drivers.FirstOrDefault(x => x.Name.Equals(name));
        }

        public void RemoveByName(string name)
        {
            var driver = GetByName(name);
            Drivers.Remove(driver);
        }
    }
}
