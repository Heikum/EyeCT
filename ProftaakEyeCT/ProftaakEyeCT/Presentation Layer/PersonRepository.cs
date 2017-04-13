using ProftaakEyectEvents.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents.Prensentation_Layer
{
    public class PersonRepository
    {
        private IPersonContext context;

        public PersonRepository(IPersonContext context)
        {
            this.context = context;
        }
        public Person Insert(Person person)
        {

            return context.Insert(person);

        }
        public List<Person> GetAll()
        {
            return context.GetAll();
        }
        public bool Update(Person person)
        {
            return context.Update(person);
        }

        public bool Delete(int id)
        {
            return context.Delete(id);
        }
        public Person GetById(int id)
        {
            return context.GetById(id );
        }

    }
}
