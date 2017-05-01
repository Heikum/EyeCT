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

        Reservation GetByID(int eventid, int campingspotid);

        Reservation InsertReservation(Reservation reservation);

        void InsertAccountReservation(Account account, int resid);

        void UpdateReservation(Reservation reservation);
        bool InsertMaterialReservation(int resID, int materialID);

        void DeleteReservation(Reservation reservation);
        List<Reservation> GetByAccountID(int accountid);
        
    }
}
