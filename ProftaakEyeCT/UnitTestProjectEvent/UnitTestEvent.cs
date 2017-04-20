using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProftaakEyectEvents;

namespace UnitTestProjectEvent
{
    [TestClass]
    public class UnitTestEvent
    {
        private Event gebeurtenis;
        [TestInitialize]
        public void TestInitialize()
        {
            this.gebeurtenis = new Event(3, "test", "eventnaam", "helmond", DateTime.Today, DateTime.Today);
        }
        [TestMethod]
        public void TestConstructorEvent()
        {
            Assert.AreEqual(3, this.gebeurtenis.id);
            Assert.AreEqual("test", this.gebeurtenis.description);
            Assert.AreEqual("eventnaam", this.gebeurtenis.name);
            Assert.AreEqual("helmond", this.gebeurtenis.location);
        }
        [TestMethod]
        public void TestTostringEvent()
        {
            string result = this.gebeurtenis.ToString();
            string expected = this.gebeurtenis.name + " | " + "Location: " + this.gebeurtenis.location + " | " + "Start Date: " + this.gebeurtenis.eventstartdate.ToString("dd/MM/yyyy") + " | " + "End Date: " + this.gebeurtenis.eventenddate.ToString("dd/MM/yyyy");
            Assert.AreEqual(expected, result);
        }
    }
}
