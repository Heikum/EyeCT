namespace ProftaakEyeCT.Presentation_Layer
{
    partial class PostPlatform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostPlatform));
            this.lbPostPlatformPosts = new System.Windows.Forms.ListBox();
            this.txtPostPlatformText = new System.Windows.Forms.TextBox();
            this.lblPostPlatformText = new System.Windows.Forms.Label();
            this.dtpPostDate = new System.Windows.Forms.DateTimePicker();
            this.txtImageLink = new System.Windows.Forms.TextBox();
            this.lblImageLink = new System.Windows.Forms.Label();
            this.btnAddPost = new System.Windows.Forms.Button();
            this.txtLoggedInUser = new System.Windows.Forms.TextBox();
            this.lblLoggedInUser = new System.Windows.Forms.Label();
            this.rbImageMedia = new System.Windows.Forms.RadioButton();
            this.rbVideoMedia = new System.Windows.Forms.RadioButton();
            this.rbGeenMedia = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtVideoName = new System.Windows.Forms.TextBox();
            this.lblVideoName = new System.Windows.Forms.Label();
            this.txtVideoLink = new System.Windows.Forms.TextBox();
            this.lblVideoLink = new System.Windows.Forms.Label();
            this.txtImageName = new System.Windows.Forms.TextBox();
            this.lblImageName = new System.Windows.Forms.Label();
            this.btnRemovePost = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPostPlatformPosts
            // 
            this.lbPostPlatformPosts.FormattingEnabled = true;
            this.lbPostPlatformPosts.ItemHeight = 25;
            this.lbPostPlatformPosts.Location = new System.Drawing.Point(461, 81);
            this.lbPostPlatformPosts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbPostPlatformPosts.Name = "lbPostPlatformPosts";
            this.lbPostPlatformPosts.Size = new System.Drawing.Size(504, 654);
            this.lbPostPlatformPosts.TabIndex = 0;
            // 
            // txtPostPlatformText
            // 
            this.txtPostPlatformText.Location = new System.Drawing.Point(35, 353);
            this.txtPostPlatformText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPostPlatformText.Multiline = true;
            this.txtPostPlatformText.Name = "txtPostPlatformText";
            this.txtPostPlatformText.Size = new System.Drawing.Size(372, 187);
            this.txtPostPlatformText.TabIndex = 1;
            // 
            // lblPostPlatformText
            // 
            this.lblPostPlatformText.AutoSize = true;
            this.lblPostPlatformText.Location = new System.Drawing.Point(30, 324);
            this.lblPostPlatformText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPostPlatformText.Name = "lblPostPlatformText";
            this.lblPostPlatformText.Size = new System.Drawing.Size(109, 25);
            this.lblPostPlatformText.TabIndex = 2;
            this.lblPostPlatformText.Text = "Post Text:";
            // 
            // dtpPostDate
            // 
            this.dtpPostDate.Enabled = false;
            this.dtpPostDate.Location = new System.Drawing.Point(35, 564);
            this.dtpPostDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpPostDate.Name = "dtpPostDate";
            this.dtpPostDate.Size = new System.Drawing.Size(372, 31);
            this.dtpPostDate.TabIndex = 3;
            this.dtpPostDate.Value = new System.DateTime(2017, 4, 20, 11, 46, 15, 0);
            // 
            // txtImageLink
            // 
            this.txtImageLink.Location = new System.Drawing.Point(997, 187);
            this.txtImageLink.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtImageLink.Name = "txtImageLink";
            this.txtImageLink.Size = new System.Drawing.Size(372, 31);
            this.txtImageLink.TabIndex = 4;
            this.txtImageLink.Leave += new System.EventHandler(this.txtImageLink_Leave);
            // 
            // lblImageLink
            // 
            this.lblImageLink.AutoSize = true;
            this.lblImageLink.Location = new System.Drawing.Point(996, 81);
            this.lblImageLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImageLink.Name = "lblImageLink";
            this.lblImageLink.Size = new System.Drawing.Size(122, 25);
            this.lblImageLink.TabIndex = 5;
            this.lblImageLink.Text = "Image Link:";
            // 
            // btnAddPost
            // 
            this.btnAddPost.Location = new System.Drawing.Point(35, 635);
            this.btnAddPost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddPost.Name = "btnAddPost";
            this.btnAddPost.Size = new System.Drawing.Size(388, 46);
            this.btnAddPost.TabIndex = 6;
            this.btnAddPost.Text = "Place Post";
            this.btnAddPost.UseVisualStyleBackColor = true;
            this.btnAddPost.Click += new System.EventHandler(this.btnAddPost_Click);
            // 
            // txtLoggedInUser
            // 
            this.txtLoggedInUser.Enabled = false;
            this.txtLoggedInUser.Location = new System.Drawing.Point(33, 289);
            this.txtLoggedInUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLoggedInUser.Name = "txtLoggedInUser";
            this.txtLoggedInUser.Size = new System.Drawing.Size(372, 31);
            this.txtLoggedInUser.TabIndex = 7;
            // 
            // lblLoggedInUser
            // 
            this.lblLoggedInUser.AutoSize = true;
            this.lblLoggedInUser.Location = new System.Drawing.Point(28, 249);
            this.lblLoggedInUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoggedInUser.Name = "lblLoggedInUser";
            this.lblLoggedInUser.Size = new System.Drawing.Size(116, 25);
            this.lblLoggedInUser.TabIndex = 8;
            this.lblLoggedInUser.Text = "Username:";
            // 
            // rbImageMedia
            // 
            this.rbImageMedia.AutoSize = true;
            this.rbImageMedia.Checked = true;
            this.rbImageMedia.Location = new System.Drawing.Point(18, 33);
            this.rbImageMedia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbImageMedia.Name = "rbImageMedia";
            this.rbImageMedia.Size = new System.Drawing.Size(101, 29);
            this.rbImageMedia.TabIndex = 9;
            this.rbImageMedia.TabStop = true;
            this.rbImageMedia.Text = "Image";
            this.rbImageMedia.UseVisualStyleBackColor = true;
            this.rbImageMedia.CheckedChanged += new System.EventHandler(this.rbImageMedia_CheckedChanged);
            // 
            // rbVideoMedia
            // 
            this.rbVideoMedia.AutoSize = true;
            this.rbVideoMedia.Location = new System.Drawing.Point(18, 73);
            this.rbVideoMedia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbVideoMedia.Name = "rbVideoMedia";
            this.rbVideoMedia.Size = new System.Drawing.Size(98, 29);
            this.rbVideoMedia.TabIndex = 10;
            this.rbVideoMedia.Text = "Video";
            this.rbVideoMedia.UseVisualStyleBackColor = true;
            this.rbVideoMedia.CheckedChanged += new System.EventHandler(this.rbVideoMedia_CheckedChanged);
            // 
            // rbGeenMedia
            // 
            this.rbGeenMedia.AutoSize = true;
            this.rbGeenMedia.Location = new System.Drawing.Point(18, 113);
            this.rbGeenMedia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbGeenMedia.Name = "rbGeenMedia";
            this.rbGeenMedia.Size = new System.Drawing.Size(160, 29);
            this.rbGeenMedia.TabIndex = 11;
            this.rbGeenMedia.Text = "Geen Media";
            this.rbGeenMedia.UseVisualStyleBackColor = true;
            this.rbGeenMedia.CheckedChanged += new System.EventHandler(this.rbGeenMedia_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbGeenMedia);
            this.groupBox1.Controls.Add(this.rbVideoMedia);
            this.groupBox1.Controls.Add(this.rbImageMedia);
            this.groupBox1.Location = new System.Drawing.Point(33, 89);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(300, 156);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Media Opties:";
            // 
            // txtVideoName
            // 
            this.txtVideoName.Enabled = false;
            this.txtVideoName.Location = new System.Drawing.Point(1001, 274);
            this.txtVideoName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVideoName.Name = "txtVideoName";
            this.txtVideoName.Size = new System.Drawing.Size(372, 31);
            this.txtVideoName.TabIndex = 13;
            // 
            // lblVideoName
            // 
            this.lblVideoName.AutoSize = true;
            this.lblVideoName.Location = new System.Drawing.Point(995, 158);
            this.lblVideoName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVideoName.Name = "lblVideoName";
            this.lblVideoName.Size = new System.Drawing.Size(135, 25);
            this.lblVideoName.TabIndex = 14;
            this.lblVideoName.Text = "Video Name:";
            // 
            // txtVideoLink
            // 
            this.txtVideoLink.Enabled = false;
            this.txtVideoLink.Location = new System.Drawing.Point(1000, 337);
            this.txtVideoLink.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVideoLink.Name = "txtVideoLink";
            this.txtVideoLink.Size = new System.Drawing.Size(372, 31);
            this.txtVideoLink.TabIndex = 15;
            this.txtVideoLink.Leave += new System.EventHandler(this.txtVideoLink_Leave);
            // 
            // lblVideoLink
            // 
            this.lblVideoLink.AutoSize = true;
            this.lblVideoLink.Location = new System.Drawing.Point(1001, 245);
            this.lblVideoLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVideoLink.Name = "lblVideoLink";
            this.lblVideoLink.Size = new System.Drawing.Size(113, 25);
            this.lblVideoLink.TabIndex = 16;
            this.lblVideoLink.Text = "Video Link";
            // 
            // txtImageName
            // 
            this.txtImageName.Location = new System.Drawing.Point(997, 110);
            this.txtImageName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtImageName.Name = "txtImageName";
            this.txtImageName.Size = new System.Drawing.Size(372, 31);
            this.txtImageName.TabIndex = 17;
            // 
            // lblImageName
            // 
            this.lblImageName.AutoSize = true;
            this.lblImageName.Location = new System.Drawing.Point(1076, 33);
            this.lblImageName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImageName.Name = "lblImageName";
            this.lblImageName.Size = new System.Drawing.Size(138, 25);
            this.lblImageName.TabIndex = 18;
            this.lblImageName.Text = "Image Name:";
            // 
            // btnRemovePost
            // 
            this.btnRemovePost.Location = new System.Drawing.Point(33, 689);
            this.btnRemovePost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemovePost.Name = "btnRemovePost";
            this.btnRemovePost.Size = new System.Drawing.Size(390, 46);
            this.btnRemovePost.TabIndex = 19;
            this.btnRemovePost.Text = "Remove post";
            this.btnRemovePost.UseVisualStyleBackColor = true;
            this.btnRemovePost.Click += new System.EventHandler(this.btnRemovePost_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProftaakEyeCT.Properties.Resources.bar;
            this.pictureBox3.Location = new System.Drawing.Point(9, 758);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1592, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProftaakEyeCT.Properties.Resources.bar;
            this.pictureBox1.Location = new System.Drawing.Point(16, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1592, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // PostPlatform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1598, 807);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnRemovePost);
            this.Controls.Add(this.lblImageName);
            this.Controls.Add(this.txtImageName);
            this.Controls.Add(this.lblVideoLink);
            this.Controls.Add(this.txtVideoLink);
            this.Controls.Add(this.lblVideoName);
            this.Controls.Add(this.txtVideoName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblLoggedInUser);
            this.Controls.Add(this.txtLoggedInUser);
            this.Controls.Add(this.btnAddPost);
            this.Controls.Add(this.lblImageLink);
            this.Controls.Add(this.txtImageLink);
            this.Controls.Add(this.dtpPostDate);
            this.Controls.Add(this.lblPostPlatformText);
            this.Controls.Add(this.txtPostPlatformText);
            this.Controls.Add(this.lbPostPlatformPosts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "PostPlatform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PostPlatform";
            this.Load += new System.EventHandler(this.PostPlatform_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPostPlatformPosts;
        private System.Windows.Forms.TextBox txtPostPlatformText;
        private System.Windows.Forms.Label lblPostPlatformText;
        private System.Windows.Forms.DateTimePicker dtpPostDate;
        private System.Windows.Forms.TextBox txtImageLink;
        private System.Windows.Forms.Label lblImageLink;
        private System.Windows.Forms.Button btnAddPost;
        private System.Windows.Forms.TextBox txtLoggedInUser;
        private System.Windows.Forms.Label lblLoggedInUser;
        private System.Windows.Forms.RadioButton rbImageMedia;
        private System.Windows.Forms.RadioButton rbVideoMedia;
        private System.Windows.Forms.RadioButton rbGeenMedia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtVideoName;
        private System.Windows.Forms.Label lblVideoName;
        private System.Windows.Forms.TextBox txtVideoLink;
        private System.Windows.Forms.Label lblVideoLink;
        private System.Windows.Forms.TextBox txtImageName;
        private System.Windows.Forms.Label lblImageName;
        private System.Windows.Forms.Button btnRemovePost;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}