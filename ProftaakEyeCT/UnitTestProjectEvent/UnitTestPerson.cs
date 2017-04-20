using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProftaakEyectEvents;

namespace UnitTestProjectEvent
{
    [TestClass]
    public class UnitTestPerson
    {
        private Person person;
        [TestInitialize]
        public void TestInitialize()
        {
            this.person = new Person(2, "hicham", "5701ND", "Helmond", "Blinkertsestraat", 5, "0636513443");
        }
        [TestMethod]
        public void TestConstructorPerson()
        {
            Assert.AreEqual("hicham", this.person.Name);
            Assert.AreEqual(2, this.person.Id);
            Assert.AreEqual("5701ND", this.person.Zipcode);
            Assert.AreEqual("Helmond", this.person.City);
            Assert.AreEqual("Blinkertsestraat", this.person.Street);
            Assert.AreEqual(5, this.person.Number);
            Assert.AreEqual("0636513443", this.person.Phonenumber);
        }
        [TestMethod]
        public void TestTostringPerson()
        {
            string result = this.person.ToString();
            string expected = this.person.Name + " " + this.person.Zipcode + " " + this.person.City + " " + this.person.Street + " " + this.person.Number + " " + this.person.Phonenumber;
            Assert.AreEqual(expected, result);
        }

    }
}
