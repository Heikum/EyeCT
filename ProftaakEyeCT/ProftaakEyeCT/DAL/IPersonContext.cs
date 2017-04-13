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
        Person GetById(int id);
        Person Insert(Person person);
        bool Delete(int id);
        bool Update(Person person);





    }
}
