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
        private Post updatePost;
        private ReactionRepository reactionrepo;
        private Reaction updateReaction;
        Loginform mainloginform = (Loginform)Application.OpenForms["Loginform"];
        private string DummyImageLink = "http://dummyimage.com/";
        private string YoutubeLink = "https://www.youtube.com/";

        public PostPlatform()
        {
            InitializeComponent();
            postrepo = new PostRepository(new PostSQLContext());
            UpdatePostControls();
        }

        private void UpdatePostControls()
        {
            string LoggedInUser = mainloginform.LoggedInUser;
            txtLoggedInUser.Text = LoggedInUser;

            lbPostPlatformPosts.Items.Clear();
            foreach (Post post in postrepo.GetByUsername(LoggedInUser))
            {
                lbPostPlatformPosts.Items.Add(post);
            }

        }

        private void UpdatePost()
        {

            updatePost.Text = txtPostPlatformText.Text;
            updatePost.Postdatetime = dtpPostDate.Value;


            if (postrepo.UpdatePost(updatePost))
            {
                UpdatePostControls();
                txtPostPlatformText.Text = "";
                txtImageLink.Text = "";
                txtImageName.Text = "";
                txtVideoLink.Text = "";
                txtVideoName.Text = "";
                updatePost = null;
            }
            else
            {
                MessageBox.Show("Updating person failed. Check if the email address is valid.");
            }
        }

        private void btnAddPost_Click(object sender, EventArgs e)
        {

          
        }

        private void PostPlatform_Load(object sender, EventArgs e)
        {
            string LoggedInUser = mainloginform.LoggedInUser;
            txtLoggedInUser.Text = LoggedInUser;
        }

        private void rbVideoMedia_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVideoMedia.Checked)
            {
                txtImageName.Enabled = false;
                txtImageLink.Enabled = false;
            }
            else if (rbVideoMedia.Checked == false)

            {
                if(rbGeenMedia.Checked == false)
                {
                    txtImageName.Enabled = true;
                    txtImageLink.Enabled = true;
                }
            }
        }

        private void rbImageMedia_CheckedChanged(object sender, EventArgs e)
        {
            if (rbImageMedia.Checked)
            {
                txtVideoName.Enabled = false;
                txtVideoLink.Enabled = false;
            }

            else if (rbImageMedia.Checked == false)

            {
                if (rbGeenMedia.Checked == false)
                {
                    txtVideoName.Enabled = true;
                    txtVideoLink.Enabled = true;
                }
            }
        }

        private void rbGeenMedia_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGeenMedia.Checked)
            {
                txtVideoName.Enabled = false;
                txtVideoLink.Enabled = false;
                txtImageName.Enabled = false;
                txtImageLink.Enabled = false;
            }
            else if (rbImageMedia.Checked)
            {
                txtImageName.Enabled = true;
                txtImageLink.Enabled = true;
            }
            else if (rbVideoMedia.Checked)
            {
                txtVideoName.Enabled = true;
                txtVideoLink.Enabled = true;
            }
        }

        private void InsertPost()
        {

        }

        private void InsertMedia()
        {

        }
    }
}
