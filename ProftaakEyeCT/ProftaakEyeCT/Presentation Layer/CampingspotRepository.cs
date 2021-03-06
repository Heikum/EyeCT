﻿using ProftaakEyeCT.DAL;
using ProftaakEyectEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyeCT.Presentation_Layer
{
    public class CampingspotRepository
    {
        private ICampingspotContext context;

        public CampingspotRepository(ICampingspotContext context)
        {
            this.context = context;
        }

        public List<CampingSpot> GetAllAvailable(Event events)
        {
            return context.GetAllAvailable(events);
        }
        public List<CampingSpot> GetByEvent(Event events)
        {
            return context.GetByEvent(events);
        }
        public int GetCampingspotById(int campingspotid)
        {
            return context.GetCampingspotById(campingspotid);
        }
        public bool UpdateCampingspot(int eventid, int campingspot, bool status)
        {
            return context.UpdateCampingspot(eventid, campingspot, status);
        }
    }
}
