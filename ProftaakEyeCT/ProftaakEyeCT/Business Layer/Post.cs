using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents
{
    public class Post
    {
        private string text { get; set; }
        private int postID { get; set; }
        private int accountID { get; set; }
        private Media media { get; set; }

        public Post(string text, int postID, int accountID)
        {
            this.text = text;
            this.postID = postID;
            this.accountID = accountID;
            this.media = null; 
        }

        public Post(string text, int postID, int accountID, Media placedmedia)
        {
            this.text = text;
            this.postID = postID;
            this.accountID = accountID;
            this.media = placedmedia; 
        }
        //onder aanpassing, via DAL post deleten uit database. 
        private void DeletePost(int postID)
        {
            this.text = null;
            this.postID = 0;
            this.accountID = 0;
            this.media = null;
        }
    }
}
