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

namespace ProftaakEyeCT.Presentation_Layer
{
    public partial class PostPlatform : Form
    {
        private PostRepository postrepo;
        private ReactionRepository reactionrepo;
        private string DummyImageLink = "http://dummyimage.com/";
        private string YoutubeLink = "https://www.youtube.com/";

        public PostPlatform()
        {
            InitializeComponent();
            postrepo = new PostRepository(new PostSQLContext());
            reactionrepo = new ReactionRepository(new ReactionSQLContext());
            UpdatePosts();
        }

        private void UpdatePosts()
        {
            //posts inladen
            lbPostPlatformPosts.DataSource = postrepo.GetAll();
        }

        private void btnAddPost_Click(object sender, EventArgs e)
        {
            if(DummyImageLink !=  )
            {

            }
            else if (txtPostPlatformText.Text = YoutubeLink)
            {

            }
        }
    }
}
