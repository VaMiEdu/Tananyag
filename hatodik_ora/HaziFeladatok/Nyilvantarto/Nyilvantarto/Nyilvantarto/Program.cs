using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Nyilvantarto
{
    public enum DrivingLicenseType { Car, Ship, Bus }

    public class DrivingLicense
    {
        public DrivingLicenseType LicenseType { get; set; }
        public string Number { get; set; }
        public DateTime ExpirationDate { get; set; }
    }

    class Nyilvantarto
    {
        private List<Human> HumanDatabase { get; set; } = new List<Human>();
        private List<Driver> DriverDatabase { get; set; } = new List<Driver>();


        public void Add(Human human)
        {
            HumanDatabase.Add(human);
        }

        public void Add(Driver driver)
        {
            DriverDatabase.Add(driver);
        }

        public DateTime PassportExpirationDate(string name)
        {
            var result = HumanDatabase.First(x => x.Name.Equals(name));

            return result.Passport.Expiration;
        }

        public List<Human> Get()
        {
            var result = new List<Human>();

            //foreach (var item in HumanDatabase)
            //{
            //    result.Add(item);
            //}

            //foreach (var item in DriverDatabase)
            //{
            //    result.Add(item);
            //}

            result.Concat(HumanDatabase);
            result.Concat(DriverDatabase);

            //result.AddRange(HumanDatabase);
            //result.AddRange(DriverDatabase);

            return result;
        }

        public List<Driver> GetDrivers()
        {
            return DriverDatabase;
        }

        public List<Human> GetPeopleOlderThan(int age)
        {
            return (List<Human>)HumanDatabase.Where(n => DateTime.Today.Year - n.BirthDay.Year > age);
        }

        public List<Human> GetPeopleFrom(string country)
        {
            List<Human> result = new List<Human>();

            //result.AddRange(HumanDatabase.Where(x => x.Passport.Country.Equals(country)));

            foreach (Human item in HumanDatabase)
            {
                if (item.Passport.Country.Equals(country))
                {
                    result.Add(item);
                }
            }

            return result;
        }
    }

    class Human
    {
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public Passport Passport { get; set; }

        public Human(string name, DateTime date)
        {

            Name = name;
            BirthDay = date;
        }
    }

    class Driver : Human
    {
        public List<DrivingLicense> DrivingLicenses { get; set; }

        public Driver(string name, DateTime date) : base(name, date)
        {
            DrivingLicenses = new List<DrivingLicense>();
        }

        public bool HasDriverLicenseFor(DrivingLicenseType licenseType)
        {
            return DrivingLicenses.Any(x => x.LicenseType == licenseType);
        }
    }


    public struct Passport
    {
        public string Number { get; set; }
        public DateTime Expiration { get; set; }
        public string Country { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Passport viktorPassportja = new Passport()
            //{
            //    Country = "Hungary",
            //    Expiration = new DateTime(2025, 01, 01),
            //    Number = "484564h1464d565",
            //};

            //Passport gyuriPassportja = new Passport()
            //{
            //    Country = "Hungary",
            //    Expiration = new DateTime(2026, 02, 02),
            //    Number = "asd454784h146465",
            //};

            //var viktor = new Human("Viktor", new DateTime(1950, 02, 19));
            //viktor.Passport = viktorPassportja;

            //var gyuri = new Human("Gyuri", new DateTime(1940, 02, 19));
            //gyuri.Passport = gyuriPassportja;

            //Passport gyuriPassportja = new Passport();
            //gyuriPassportja.Number = "foo001";
            //gyuriPassportja.Country = "Hungary";
            //gyuriPassportja.Expiration = DateTime.Now;

            //Driver vezeto = new Driver("Viktor", new DateTime(1995,01,01));
            //vezeto.Passport = gyuriPassportja;

            Nyilvantarto nyilvantarto = new Nyilvantarto();

            Human john = new Human("John", new DateTime(1944, 4, 4));
            Human ringo = new Human("Ringo", new DateTime(1933, 03, 03));

            var georgeLicensei = new List<DrivingLicense>();

            var georgeElsoLicense = new DrivingLicense();
            georgeElsoLicense.LicenseType = DrivingLicenseType.Car;
            georgeElsoLicense.ExpirationDate = new DateTime(2025, 01, 09);
            georgeElsoLicense.Number = "Foo007";

            georgeLicensei.Add(georgeElsoLicense);

            georgeLicensei.Add(new DrivingLicense()
            {
                Number = "Foo001",
                ExpirationDate = new DateTime(2044, 04, 05),
                LicenseType = DrivingLicenseType.Ship
            });

            Driver george = new Driver("George", new DateTime(1955, 05, 05));
            george.DrivingLicenses.AddRange(georgeLicensei);


            Driver peter = new Driver("Peter", new DateTime(1955, 05, 06));

            DrivingLicense peterEgyikLicense = new DrivingLicense()
            {
                Number = "Foo012",
                ExpirationDate = new DateTime(2044, 09, 09),
                LicenseType = DrivingLicenseType.Bus,
            };

            peter.DrivingLicenses.Add(peterEgyikLicense);

            nyilvantarto.Add(john);
            nyilvantarto.Add(ringo);
            nyilvantarto.Add(george);
            nyilvantarto.Add(peter);

        }
    }
}
