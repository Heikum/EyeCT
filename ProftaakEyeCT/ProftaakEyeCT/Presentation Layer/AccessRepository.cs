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

        public bool AddRFIDstatusnewaccount(int id)
        {
            return context.AddRFIDstatusnewaccount(id);
        }
        public bool GetStatus(string acc)
        {
            return context.GetStatus(acc);
        }

        public Access AddRFID(Access access, Account acc)
        {
            return context.AddRFID(access, acc);
        }

        public bool RemoveRFID(int id)
        {
            return context.RemoveRFID(id);
        }

        public bool GainAccess(bool accessBool, Account acc)
        {
            return context.GainAccess(accessBool, acc);
        }

        public List<Account> GetAllInside()
        {
            return context.GetAllInside();
        }

        public bool UpdateInside(Account acc, bool accessbool)
        {
            return context.UpdateInside(acc, accessbool);
        }

        public List<Account> GetAllOutside()
        {
            return context.GetAllOutside();
        }

        public bool ReservationUpdate(int ReservationID, int AccountID)
        {
            return context.ReservationUpdate(ReservationID, AccountID);
        }

        public string EventReservationAccess(int AccountID)
        {
            return context.EventReservationAccess(AccountID);
        }
        public bool CheckStatusForEvent(string eventname, string username)
        {
            return context.CheckStatusForEvent(eventname, username);
        }
    }
}
