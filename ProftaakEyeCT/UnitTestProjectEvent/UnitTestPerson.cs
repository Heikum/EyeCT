using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProftaakEyectEvents;

namespace UnitTestProjectEvent
{
    [TestClass]
    public class UnitTestPerson
    {
        private Person person;
        public void TestInitialize()
        {
            person = new Person(2, "hicham", "5701ND", "Helmond", "Blinkertsestraat", 5, "0636513443");
        }
        [TestMethod]
        public void TestConstructorPerson()
        {
            person = new Person(2, "hicham", "5701ND", "Helmond", "Blinkertsestraat", 5, "0636513443");
            Assert.AreEqual("hicham", person.Name);
            Assert.AreEqual(2, person.Id);
            Assert.AreEqual("5701ND", person.Zipcode);
            Assert.AreEqual("Helmond", person.City);
            Assert.AreEqual("Blinkertsestraat", person.Street);
            Assert.AreEqual(5, person.Number);
            Assert.AreEqual("0636513443", person.Phonenumber);
        }
    }
}
