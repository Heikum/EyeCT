using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents
{
    public class Reservation
    {
        private readonly int id;
        private DateTime reservationdate;
        private bool paymentstatus;
        private int eventid;
        private int campingspotid;

        public int Id => id;

        public DateTime Reservationdate { get { return reservationdate; } set { reservationdate = value; } }
        public bool Paymentstatus { get { return paymentstatus; } set { paymentstatus = value; } }
        public int Eventid { get { return eventid; } set  { eventid = value; } }
        public int Campingspotid { get { return campingspotid; } set { campingspotid = value; } }

        public Reservation(int id, DateTime reservationdate, bool paymentstatus, int eventid, int campingspotid)
        {
            this.id = id;
            this.reservationdate = reservationdate;
            this.paymentstatus = paymentstatus;
            this.eventid = eventid;
            this.campingspotid = campingspotid;
            
        }
        public Reservation(DateTime reservationdate, bool paymentstatus, int eventid, int campingspotid)
            : this(0, reservationdate, paymentstatus, eventid, campingspotid)
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
        public override string ToString()
        {
            return reservationdate + " " + paymentstatus + " " + eventid + " " + campingspotid ;
        }
    }
}

