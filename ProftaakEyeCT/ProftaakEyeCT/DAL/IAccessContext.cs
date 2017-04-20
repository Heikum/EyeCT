using ProftaakEyectEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyeCT.DAL
{
    public interface IAccessContext
    {
        bool GetStatus(Access access);

        Access AddRFID(Access access);

        bool RemoveRFID(int id);

        bool GainAccess(bool accessBool, Access access);
    }
}
