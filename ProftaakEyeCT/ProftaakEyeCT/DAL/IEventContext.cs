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

        bool UpdateEvents(Event events);

        bool DeleteEvent(int id);
        void InsertCampingspot(Event events, int campingspot, bool status);
        Event GetByName(string eventname);

    }
}
