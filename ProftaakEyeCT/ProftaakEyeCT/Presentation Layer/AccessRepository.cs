using ProftaakEyectEvents;
using ProftaakEyeCT.DAL;
using ProftaakEyectEvents.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyeCT.Presentation_Layer
{
    public class AccessRepository
    {
        private IAccessContext context;

        public AccessRepository(IAccessContext context)
        {
            this.context = context;
        }

        public bool GetStatus(Access access)
        {
            return false;
        }
    }
}
