using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents
{
    public class Reservation
    {
        private readonly int id = -1;
        private int price;
        private int personAmount;
        private DateTime date;
        private string location;
        private bool paymentstatus;
        private Account mainreservator;
        private Account otherreservator;

        public int Id { get; set; }
        public int Price { get; set; }
        public int PersonAmount { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public bool Paymentstatus { get; set; }
        public Account Mainreservator { get; set; }
        public Account Otherreservator { get; set; }

        public Reservation(int id, int price, int personAmount, DateTime date, string location, bool paymentstatus)
        {
            this.price = price;
            this.personAmount = personAmount;
            this.date = date;
            this.location = location;
            this.paymentstatus = paymentstatus;
            this.mainreservator = mainreservator;
            this.otherreservator = otherreservator;
        }
        public Reservation(int price, int personAmount, DateTime date, string location, bool paymentstatus)
            : this(-1, price, personAmount, date, location, paymentstatus)
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

