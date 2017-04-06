using ProftaakEyectEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyeCT.DAL
{
    public interface IEventContext
    {
        List<Event> GetAllEvents();

        Event InsertEvent(Event events);

        void UpdateEvents(Event events);

        void DeleteEvent(Event events);
    }
}
