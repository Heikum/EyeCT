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

        public bool GetStatus(Account acc)
        {
            return context.GetStatus(acc);
        }

        public Access AddRFID(Access access, Account acc)
        {
            return context.AddRFID(access, acc);
        }

        bool RemoveRFID(int id)
        {
            return context.RemoveRFID(id);
        }

        bool GainAccess(bool accessBool, Account acc)
        {
            return context.GainAccess(accessBool, acc);
        }
    }
}
