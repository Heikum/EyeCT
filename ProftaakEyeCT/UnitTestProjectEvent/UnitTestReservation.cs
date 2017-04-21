using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProftaakEyectEvents;
using ProftaakEyectEvents.DAL;
using ProftaakEyeCT.Presentation_Layer;

namespace UnitTestProjectEvent
{
    [TestClass]
    public class ReservationTest
    {
        private Reservation reservation;
        private Event events;
        private CampingSpot campingspot;


        [TestInitialize]

        public void TestInitialize()
        {
            events = new Event(1, "blah", "blah", "Hier", Convert.ToDateTime("2017-04-06 11:11:01") , Convert.ToDateTime("2017-04-06 11:11:01"));
            campingspot = new CampingSpot(1,false, 4, "Comfort", 265);
            this.reservation = new Reservation(Convert.ToDateTime("2017-04-06 11:11:01"), false, events.id, campingspot.Id);
        }
        [TestMethod]
        public void Reservationtest()
        {
            Assert.AreEqual(Convert.ToDateTime("2017-04-06 11:11:01"), reservation.Reservationdate);
            Assert.AreEqual(false, reservation.Paymentstatus);
            Assert.AreEqual(1, reservation.Eventid);
            Assert.AreEqual(1, reservation.Campingspotid);

        }
    }
}
