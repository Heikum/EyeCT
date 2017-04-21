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
        [TestInitialize]
        public void TestInitialize()
        {
            this.account = new Account(2, "Student", 24, "richard", "testmail@gmail.com", "1243", false);
        }
        [TestMethod]
        public void TestConstructorAccount()
        {
            Assert.AreEqual("richard", this.account.Username);
            Assert.AreEqual(2, this.account.Id);
            Assert.AreEqual(24, this.account.Personid);
            Assert.AreEqual("Student", this.account.Kind);
            Assert.AreEqual("testmail@gmail.com", this.account.Emailadress);
            Assert.AreEqual(false, this.account.Rights);
            Assert.AreEqual("1243", this.account.Password);
        }
        [TestMethod]
        public void TestTostringAccount()
        {
            string result = this.account.ToString(); 
            string expected = this.account.Username + " " + this.account.Password + " " + this.account.Emailadress;
            Assert.AreEqual(expected, result);
        }
    }
}
