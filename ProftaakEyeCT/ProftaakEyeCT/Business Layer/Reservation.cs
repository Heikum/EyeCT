using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents
{
    public class Reservation
    {
        private int price;
        private int personAmount;
        private DateTime date;
        private string location;
        private bool paymentstatus;
        private Account mainreservator;
        private Account otherreservator;
        
        public Reservation(int Price, int Personamount, DateTime Date, string Location, string Paymentstatus, string Mainreservator, int room)
        {

        }
        public bool checkAvalibility(int Room)
        {
            return true;
        }
        public void Reserve(Account Reservedby, Event Event, string CampingSpot)
        {

        }
        public void Reserve(Account Reservedby, Event Event, string CampingSpot, Material Material)
        {

        }
        public bool checkAccess()
        {
            return true;
        }
    }
}
