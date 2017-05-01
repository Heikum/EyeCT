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
    public partial class ReportComplaint : Form
    {
        private PostRepository postrepo;
        private ReactionRepository reactionrepo;
        MediaPlatform mediaplatform = (MediaPlatform)Application.OpenForms["MediaPlatform"];
        public Post post;
        public ReportComplaint()
        {
            InitializeComponent();
            postrepo = new PostRepository(new PostSQLContext());
            reactionrepo = new ReactionRepository(new ReactionSQLContext());
        }

        private void btnComplaintSend_Click(object sender, EventArgs e)
        {

            //post = mediaplatform.;
            post = mediaplatform.reportingpost;
            if(post != null && txtReportComplaint.Text != null)
            {
                postrepo.InsertReportedPost(post, txtReportComplaint.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("First fill in your complaint");
            }
            
        }
    }
}
