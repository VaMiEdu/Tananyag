using System;
using System.Collections.Generic;
using System.Linq;

namespace Nyilvantarto
{
    class Nyilvantarto
    {
        private List<Human> HumanDatabase { get; set; }

        public void New(Human human)
        {
            HumanDatabase.Add(human);
        }

        public DateTime PassportExpirationDate(string name) => HumanDatabase.First(x => x.Name.Equals(name)).Passport.Expiration;

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
            Passport viktorPassportja = new Passport()
            {
                Country = "Hungary",
                Expiration = new DateTime(2025, 01, 01),
                Number = "484564h1464d565",
            };

            Passport gyuriPassportja = new Passport()
            {
                Country = "Hungary",
                Expiration = new DateTime(2026, 02, 02),
                Number = "asd454784h146465",
            };

            var viktor = new Human("Viktor", new DateTime(1950, 02, 19));
            viktor.Passport = viktorPassportja;

            var gyuri = new Human("Gyuri", new DateTime(1940, 02, 19));
            gyuri.Passport = gyuriPassportja;
        }
    }
}
