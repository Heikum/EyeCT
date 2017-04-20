using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents.DAL
{
    public interface IReservationContext
    {
        List<Reservation> GetAll();

        Reservation GetByID(int Id);

        Reservation InsertReservation(Reservation reservation, Event events, CampingSpot campingspot);

        void UpdateReservation(Reservation reservation);

        void DeleteReservation(Reservation reservation);
    }
}
