using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProftaakEyectEvents;

namespace UnitTestProjectEvent
{
    [TestClass]
    public class UnitTestPost
    {
        private Post post;
        [TestInitialize]
        public void TestInitialize()
        {
            this.post = new Post(3, 4, "Hallo", DateTime.Today);
        }
        [TestMethod]
        public void TestConstructorPost()
        {
            Assert.AreEqual(3, this.post.PostID);
            Assert.AreEqual(4, this.post.MediaID);
            Assert.AreEqual("Hallo", this.post.Text);
        }
    }
}
