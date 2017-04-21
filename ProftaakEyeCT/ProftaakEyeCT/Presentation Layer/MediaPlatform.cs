using ProftaakEyeCT.DAL;
using ProftaakEyeCT.Presentation_Layer;
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

namespace ProftaakEyeCT
{
    public partial class MediaPlatform : Form
    {
        private PostRepository postrepo;
        private ReactionRepository reactionrepo;
        public MediaPlatform()
        {
            InitializeComponent();
            postrepo = new PostRepository(new PostSQLContext());
            reactionrepo = new ReactionRepository(new ReactionSQLContext());
            UpdatePosts();

        }

        private void UpdatePosts()
        {
            //posts inladen
            lbMediaPosts.DataSource = postrepo.GetAll();
        }

        private void UpdateReactions()
        {
            //reacties inladen
            var selectedpost = lbMediaPosts.SelectedItem as Post;
            lbMediaReactions.DataSource = reactionrepo.GetByPost(selectedpost);
            
        }

        private void MediaPlatform_Load(object sender, EventArgs e)
        {

        }

        private void lbMediaPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateReactions();
        }

        private void btnOpenPostPlatform_Click(object sender, EventArgs e)
        {
            PostPlatform postplatform = new PostPlatform();
            postplatform.Show();
        }
    }
}
