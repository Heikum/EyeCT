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
        public void InsertAccountReservation(Account account, int resid)
        {
            context.InsertAccountReservation(account, resid);
        }
        public Reservation GetById(int eventid, int campingspotsid)
        {
            return context.GetByID(eventid, campingspotsid);
        }

    }
}
