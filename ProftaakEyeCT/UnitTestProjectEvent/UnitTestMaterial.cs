using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProftaakEyectEvents;

namespace UnitTestProjectEvent
{
    [TestClass]
    public class UnitTestMaterial
    {
        private Material material;
        [TestInitialize]
        public void TestInitialize()
        {
            this.material = new Material(5, "Sok", (decimal)2.2, 24);
        }
        [TestMethod]
        public void TestConstructorMaterial()
        {
            Assert.AreEqual(5, this.material.Id); 
            Assert.AreEqual("Sok", this.material.Name);
            Assert.AreEqual(24, this.material.Stock);
            Assert.AreEqual((decimal)2.2, this.material.Price);
        }
        [TestMethod]
        public void TestTostringMaterial()
        {
            string result = this.material.ToString();
            string expected = this.material.Name + " " + this.material.Price + " " + this.material.Stock;
            Assert.AreEqual(expected, result);
        }
    }
}
