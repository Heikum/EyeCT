using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents
{
    public class Post
    {
        private string text;
        private int postID;
        private DateTime postdatetime;
        private Video videolink;
        private Image imagelink;
        private Account postedby;
        //hoi

        public Post(int postID, string text, DateTime postdatetime)
        {
            this.text = text;
            this.postID = postID;
            this.Postdatetime = postdatetime;
         
        }

        public bool AddImage(Image image)
        {
            if (this.Imagelink == null)
            {
                this.Imagelink = image;
                return true;
            }
            return false;
        }

        public bool AddVideo(Video video)
        {
            if (this.Videolink == null)
            {
                this.Videolink = video;
                return true;
            }
            return false;
        }

        public string Text
        {
            get
            {
                return text;
            }

            set
            {
                text = value;
            }
        }

        public int PostID
        {
            get
            {
                return postID;
            }

            set
            {
                postID = value;
            }
        }


        public DateTime Postdatetime
        {
            get
            {
                return postdatetime;
            }

            set
            {
                postdatetime = value;
            }
        }

        public Account Postedby
        {
            get
            {
                return postedby;
            }

            set
            {
                postedby = value;
            }
        }

        public Video Videolink
        {
            get
            {
                return videolink;
            }

            set
            {
                videolink = value;
            }
        }

        public Image Imagelink
        {
            get
            {
                return imagelink;
            }

            set
            {
                imagelink = value;
            }
        }
    }
}
