using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents
{
    public class Reservation
    {
        private int price { get; set; }
        private int personAmount { get; set; }
        private DateTime date { get; set; }
        private string location { get; set; }
        private bool paymentstatus { get; set; }
        private Account mainreservator { get; set; }
        private Account otherreservator { get; set; }
        
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
