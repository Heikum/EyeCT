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
    public partial class ReactionPlatform : Form
    {
        private ReactionRepository reactionrepo;
        Loginform mainloginform = (Loginform)Application.OpenForms["Loginform"];
        MediaPlatform platform = (MediaPlatform)Application.OpenForms["MediaPlatform"];

        public ReactionPlatform()
        {
            InitializeComponent();
            reactionrepo = new ReactionRepository(new ReactionSQLContext());
            UpdateControls();
        }

        public void UpdateControls()
        {
            txtUsername.Text = mainloginform.LoggedInUser;
        }

        private void btnAddReaction_Click(object sender, EventArgs e)
        {
            reactionrepo.Insert(new Reaction(txtReactionText.Text, Convert.ToInt32(txtReactionID.Text), DateTime.Now, mainloginform.accountid, platform.selectedPostID));
            MessageBox.Show("Reaction added");
            this.Close();
        }
    }
}
