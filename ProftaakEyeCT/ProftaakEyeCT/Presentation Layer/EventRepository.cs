using ProftaakEyeCT.DAL;
using ProftaakEyectEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyeCT.Presentation_Layer
{
    public class EventRepository
    {
        private IEventContext context;

        public EventRepository(IEventContext context)
        {
            this.context = context;
        }

        public List<Event> GetAllEvents()
        {
            return context.GetAllEvents();
        }

        public Event InsertEvent(Event events)
        {
            return context.InsertEvent(events);
        }

        public bool UpdateEvents(Event events)
        {
            return context.UpdateEvents(events);
        }

        public bool DeleteEvent(int id)
        {
            return context.DeleteEvent(id);
        }
        public void InsertCampingspot(Event events, int campingspot, bool status)
        {
            context.InsertCampingspot(events, campingspot, status);
        }
        public Event GetByName(string eventname)
        {
            return context.GetByName(eventname);
        }

    }
}
