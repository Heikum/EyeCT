﻿using ProftaakEyectEvents;
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
        MediaPlatform mediaplatform = (MediaPlatform)Application.OpenForms["MediaPlatform"];
        public Post post;
        public ReportComplaint()
        {
            InitializeComponent();
        }

        private void btnComplaintSend_Click(object sender, EventArgs e)
        {
            post = mediaplatform.;
        }
    }
}
