using ProftaakEyeCT.DAL;
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
      
        public List<CampingSpot> GetAllAvailable()
        {
            return context.GetAllAvailable();
        }
    }
}
