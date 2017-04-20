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
        public Reservation InsertReservation(Reservation reservation, Event events, CampingSpot campingspot)
        {

            return context.InsertReservation(reservation, events, campingspot);

        }

    }
}
