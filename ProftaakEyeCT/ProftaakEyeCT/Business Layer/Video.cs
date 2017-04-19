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

        public string VideoName
        {
            get
            {
                return videoName;
            }

            set
            {
                videoName = value;
            }
        }

        public string VideoLink
        {
            get
            {
                return videoLink;
            }

            set
            {
                videoLink = value;
            }
        }

        public Video(int Id, string videoName, string videoLink) : base(Id)
        {
            VideoName = videoName;
            VideoLink = videoLink;
        }

      

        public override string ToString()
        {
            return videoName + "-" +videoLink; 
        }

    }
}