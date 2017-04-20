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
        bool GetStatus(Account acc);

        Access AddRFID(Access access, Account acc);

        bool RemoveRFID(int id);

        bool GainAccess(bool accessBool, Account acc);
    }
}
