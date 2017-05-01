using ProftaakEyectEvents;
using ProftaakEyectEvents.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyeCT.Presentation_Layer
{
    public class ReservationRepository
    {
        private IReservationContext context;

        public ReservationRepository(IReservationContext context)
        {
            this.context = context;
        }
        public List<Reservation> GetAllAccounts()
        {
            return context.GetAll();
        }
        public Reservation InsertReservation(Reservation reservation)
        {

            return context.InsertReservation(reservation);

        }

        public bool InsertMaterialReservation(int resid, int materialid)
        {
            context.InsertMaterialReservation(resid, materialid);
            return true;
        }
        public void InsertAccountReservation(Account account, int resid)
        {
            context.InsertAccountReservation(account, resid);
        }
        public Reservation GetById(int eventid, int campingspotsid)
        {
            return context.GetByID(eventid, campingspotsid);
        }
        public List<Reservation> GetByAccountID(int accountid)
        {
            return context.GetByAccountID(accountid);
        }
        public void DeleteReservation(Reservation reservation)
        {
            context.DeleteReservation(reservation);
        }

    }
}
