﻿using ProftaakEyeCT.DAL;
using ProftaakEyeCT.Presentation_Layer;
using ProftaakEyectEvents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            if (lbMediaPosts.SelectedIndex != -1)
            {
                string text = lbMediaPosts.GetItemText(lbMediaPosts.SelectedItem);
                string[] result = text.Split('-');

                if (result[6].StartsWith("https://www.youtube.com/"))
                {
                    webBrowser1.Show();
                    string[] id = result[6].Split('=');
                    string urlBase = "http://www.youtube.com/v/";
                    webBrowser1.Navigate(urlBase + id[1]);
                    pbMedia.Hide();
                }
                else
                {
                    pbMedia.Show();
                    pbMedia.ImageLocation = result[6];
                    webBrowser1.Hide();
                }
                
            }
        }

        private void btnOpenPostPlatform_Click(object sender, EventArgs e)
        {
            PostPlatform postplatform = new PostPlatform();
            postplatform.Show();
        }
    }
}
