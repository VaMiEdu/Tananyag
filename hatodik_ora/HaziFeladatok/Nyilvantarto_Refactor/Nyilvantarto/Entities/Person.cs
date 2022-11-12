using System;
using System.Collections.Generic;
using System.Text;

namespace Nyilvantarto.Entities
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public Passport Passport { get; set; }

        public Person(string name, DateTime date)
        {
            Name = name;
            BirthDay = date;
        }
    }
}
