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
        List<Account> GetAllInside();
        bool GetStatus(string name);

        Access AddRFID(Access access, Account acc);

        bool RemoveRFID(int id);

        bool AddRFIDstatusnewaccount(int id); 

        bool GainAccess(bool accessBool, Account acc);

        bool UpdateInside(Account acc, bool accessbool);

        List<Account> GetAllOutside();
    }
}
