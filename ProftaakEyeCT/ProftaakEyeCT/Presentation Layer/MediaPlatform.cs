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
        public MediaPlatform()
        {
            InitializeComponent();
            postrepo = new PostRepository(new PostSQLContext());
            UpdateControls();

        }

        private void UpdateControls()
        {
            lbMediaPosts.Items.Clear();
            foreach (Post post in postrepo.GetAll())
            {
                lbMediaPosts.Items.Add(post);
            }


        }
    }
}
