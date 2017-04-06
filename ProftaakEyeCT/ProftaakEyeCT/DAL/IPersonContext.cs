using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents.DAL
{
    public interface IPersonContext
    {

        List<Person> GetAll();
        Person GetByName(string Name);
        Person Insert(Person person);
        bool Delete(int id);
        bool Update(Person person);





    }
}
