using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents
{
    public class Video : Media
    {
        private string videoName;
        private string videoLink;
        public string VideoName { get { return VideoName; } set { VideoName = value; } }
        public string VideoLink { get { return VideoLink; } set { VideoLink = value; } }

        public Video(string videoName, string videoLink, int MediaID, int MediaType) : base(MediaID, MediaType)
        {
            VideoName = videoName;
            VideoLink = videoLink;
        }
        public string GetVideoLink()
        {
            return VideoLink;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
    }