using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeriLogDemo.Model
{
    public interface IPersonRepository
    {
        IList<Person> GetAllPersons();
        Person GetPerson(int id);
    }
}
