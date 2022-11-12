using Nyilvantarto.Entities;
using Nyilvantarto.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nyilvantarto
{
    public class PersonRepository : IRepository<Person>
    {
        private List<Person> Persons { get; set; } = new List<Person>();

        public List<Person> Get() => Persons;

        public Person GetByName(string name)
        {
            return Persons.FirstOrDefault(x => x.Name.Equals(name));
        }

        public bool Add(Person person)
        {
            if (Persons.Any(x => x.Name.Equals(person.Name)))
            {
                return false;
            }

            Persons.Add(person);
            return true;
        }

        public void RemoveByName(string name)
        {
            var person = GetByName(name);
            Persons.Remove(person);
        }
    }
}
