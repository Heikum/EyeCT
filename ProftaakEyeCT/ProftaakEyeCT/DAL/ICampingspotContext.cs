using ProftaakEyectEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyeCT.DAL
{
    public interface ICampingspotContext
    {
        List<CampingSpot> GetAllAvailable(Event events);
        List<CampingSpot> GetByEvent(Event events);
        int GetCampingspotById(int campingspotid);
        bool UpdateCampingspot(int eventid, int campingspot, bool status);

    }
}
