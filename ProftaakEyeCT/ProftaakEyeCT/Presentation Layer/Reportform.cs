using ProftaakEyeCT.DAL;
using ProftaakEyectEvents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProftaakEyeCT.Presentation_Layer
{
    public partial class Reportform : Form
    {
        private PostRepository postrepo;
        private Post updatePost;
        private ReactionRepository reactionrepo;
        public Reportform()
        {
            InitializeComponent();
            postrepo = new PostRepository(new PostSQLContext());
            reactionrepo = new ReactionRepository(new ReactionSQLContext());
            UpdatePosts();
        }

        private void UpdatePosts()
        {
            //posts inladen
            lbReportedPosts.DataSource = postrepo.GetAllReportedPosts();
        }
        private void UpdateReactions()
        {
            //reacties inladen
            var selectedpost = lbReportedPosts.SelectedItem as Post;
            lbReportedPostReactions.DataSource = reactionrepo.GetByPost(selectedpost);

        }

        private void lbReportedPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateReactions();
            


            if (lbReportedPosts.SelectedIndex != -1)
            {
                var selectedpost = lbReportedPosts.SelectedItem as Post;
                lbComplaints.DataSource = postrepo.GetReportPostComplaint(selectedpost);
                string text = lbReportedPosts.GetItemText(lbReportedPosts.SelectedItem);
                string[] result = text.Split('-');


                if (result[6].StartsWith("https://www.youtube.com/"))
                {
                    wbVideo.Show();
                    string[] id = result[6].Split('=');
                    string urlBase = "http://www.youtube.com/v/";
                    wbVideo.Navigate(urlBase + id[1]);
                    pbMedia.Hide();
                }
                else
                {
                    pbMedia.Show();
                    pbMedia.ImageLocation = result[6];
                    wbVideo.Hide();
                }


            }

        }

        private void btnRemoveComplaint_Click(object sender, EventArgs e)
        {
            updatePost = (Post)lbReportedPosts.SelectedItem;
            postrepo.RemoveComplaint(updatePost.PostID);
            UpdatePosts();
        
        }

        private void btnReportedPostRemove_Click(object sender, EventArgs e)
        {
            var selectedpost = lbReportedPosts.SelectedItem as Post;
            postrepo.Delete(selectedpost.PostID);
        }
    }
}
