using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProftaakEyectEvents;

namespace UnitTestProjectEvent
{
    [TestClass]
    public class UnitTestVideo
    {
        private Video video;
        [TestInitialize]
        public void TestInitialize()
        {
            this.video = new Video(3, "Puppy video", "https://www.youtube.com/watch?v=jhpGJb7KPuA");
        }
        [TestMethod]
        public void TestConstructorVideo()
        {
            Assert.AreEqual(3, this.video.MediaID);
            Assert.AreEqual("Puppy video", this.video.VideoName);
            Assert.AreEqual("https://www.youtube.com/watch?v=jhpGJb7KPuA", this.video.VideoLink);
        }
        [TestMethod]
        public void TestTostringVideo()
        {
            string result = this.video.ToString();
            string expected = this.video.VideoName + "-" + this.video.VideoLink;
            Assert.AreEqual(expected, result);
        }
    }
}
