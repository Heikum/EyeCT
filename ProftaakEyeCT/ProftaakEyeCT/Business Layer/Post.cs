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
        private int mediaID;
        private DateTime postdatetime;
        private Video videolink;
        private Image imagelink;
        private Student postedByStudent;
        private Admin postedByAdmin;
        

        public Post(int postID, int mediaID, string text, DateTime postdatetime)
        {
            this.text = text;
            this.postID = postID;
            this.Postdatetime = postdatetime;
            this.MediaID = mediaID;

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

        public bool AddStudent(Student student)
        {
            if (this.PostedByStudent == null)
            {
                this.PostedByStudent = student;
                return true;
            }
            return false;
        }

        public bool AddAdmin(Admin admin)
        {
            if (this.PostedByAdmin == null)
            {
                this.PostedByAdmin = admin;
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

        public int MediaID
        {
            get
            {
                return mediaID;
            }

            set
            {
                mediaID = value;
            }
        }

        public Student PostedByStudent
        {
            get
            {
                return postedByStudent;
            }

            set
            {
                postedByStudent = value;
            }
        }

        public Admin PostedByAdmin
        {
            get
            {
                return postedByAdmin;
            }

            set
            {
                postedByAdmin = value;
            }
        }

        public override string ToString()
        {
            return "username: " + postedByAdmin + "" + postedByStudent + "-" + text + "-" + postdatetime + "-" + imagelink + videolink; 
        }
    }
}
