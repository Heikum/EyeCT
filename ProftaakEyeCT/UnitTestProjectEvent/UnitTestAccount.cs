using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProftaakEyectEvents;
using ProftaakEyeCT; 


namespace UnitTestProjectEvent
{
    [TestClass]
    public class UnitTestAccount
    {
        private Account account;
        public void TestInitialize()
        {
            account = new Account(2, "Student", 24, "richard", "testmail@gmail.com", "1243", false);
        }
        [TestMethod]
        public void TestConstructorAccount()
        {
            account = new Account(2, "Student", 24, "richard", "testmail@gmail.com", "1243", false);
            Assert.AreEqual("richard", account.Username);
            Assert.AreEqual(2, account.Id);
            Assert.AreEqual(24, account.Personid);
            Assert.AreEqual("Student", account.Kind);
            Assert.AreEqual("testmail@gmail.com", account.Emailadress);
            Assert.AreEqual(false, account.Rights);
            Assert.AreEqual("1243", account.Password);
        }
    }
}
