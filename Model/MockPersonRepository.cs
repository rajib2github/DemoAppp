using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeriLogDemo.Model
{
    public class MockPersonRepository : IPersonRepository
    {
        private static List<Person> personList;
        public IList<Person> GetAllPersons()
        {
            var persons = new List<Person>
            {
                new Person
                {
                    Id = 1,
                    FirstName = "avinash",
                    LastName = "deshmukh",
                    Age = 36,
                    Gender = "Male"
                },
                new Person
                {
                    Id = 2,
                    FirstName = "rajib",
                    LastName = "halder",
                    Age = 40,
                    Gender = "Male"
                }
            };
            personList = persons;

            return personList;
        }

        public Person GetPerson(int id)
        {
            return personList.Where(p => p.Id == id).FirstOrDefault();
        }
    }
}
