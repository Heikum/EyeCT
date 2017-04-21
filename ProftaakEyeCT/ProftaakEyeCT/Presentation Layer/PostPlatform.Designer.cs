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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPostPlatformPosts
            // 
            this.lbPostPlatformPosts.FormattingEnabled = true;
            this.lbPostPlatformPosts.ItemHeight = 16;
            this.lbPostPlatformPosts.Location = new System.Drawing.Point(338, 21);
            this.lbPostPlatformPosts.Name = "lbPostPlatformPosts";
            this.lbPostPlatformPosts.Size = new System.Drawing.Size(338, 420);
            this.lbPostPlatformPosts.TabIndex = 0;
            // 
            // txtPostPlatformText
            // 
            this.txtPostPlatformText.Location = new System.Drawing.Point(11, 190);
            this.txtPostPlatformText.Multiline = true;
            this.txtPostPlatformText.Name = "txtPostPlatformText";
            this.txtPostPlatformText.Size = new System.Drawing.Size(250, 121);
            this.txtPostPlatformText.TabIndex = 1;
            // 
            // lblPostPlatformText
            // 
            this.lblPostPlatformText.AutoSize = true;
            this.lblPostPlatformText.Location = new System.Drawing.Point(9, 170);
            this.lblPostPlatformText.Name = "lblPostPlatformText";
            this.lblPostPlatformText.Size = new System.Drawing.Size(71, 17);
            this.lblPostPlatformText.TabIndex = 2;
            this.lblPostPlatformText.Text = "Post Text:";
            // 
            // dtpPostDate
            // 
            this.dtpPostDate.Enabled = false;
            this.dtpPostDate.Location = new System.Drawing.Point(12, 366);
            this.dtpPostDate.Name = "dtpPostDate";
            this.dtpPostDate.Size = new System.Drawing.Size(249, 22);
            this.dtpPostDate.TabIndex = 3;
            this.dtpPostDate.Value = new System.DateTime(2017, 4, 20, 11, 46, 15, 0);
            // 
            // txtImageLink
            // 
            this.txtImageLink.Location = new System.Drawing.Point(714, 190);
            this.txtImageLink.Name = "txtImageLink";
            this.txtImageLink.Size = new System.Drawing.Size(250, 22);
            this.txtImageLink.TabIndex = 4;
            // 
            // lblImageLink
            // 
            this.lblImageLink.AutoSize = true;
            this.lblImageLink.Location = new System.Drawing.Point(711, 170);
            this.lblImageLink.Name = "lblImageLink";
            this.lblImageLink.Size = new System.Drawing.Size(80, 17);
            this.lblImageLink.TabIndex = 5;
            this.lblImageLink.Text = "Image Link:";
            // 
            // btnAddPost
            // 
            this.btnAddPost.Location = new System.Drawing.Point(12, 411);
            this.btnAddPost.Name = "btnAddPost";
            this.btnAddPost.Size = new System.Drawing.Size(259, 30);
            this.btnAddPost.TabIndex = 6;
            this.btnAddPost.Text = "Place Post";
            this.btnAddPost.UseVisualStyleBackColor = true;
            this.btnAddPost.Click += new System.EventHandler(this.btnAddPost_Click);
            // 
            // txtLoggedInUser
            // 
            this.txtLoggedInUser.Enabled = false;
            this.txtLoggedInUser.Location = new System.Drawing.Point(12, 145);
            this.txtLoggedInUser.Name = "txtLoggedInUser";
            this.txtLoggedInUser.Size = new System.Drawing.Size(250, 22);
            this.txtLoggedInUser.TabIndex = 7;
            // 
            // lblLoggedInUser
            // 
            this.lblLoggedInUser.AutoSize = true;
            this.lblLoggedInUser.Location = new System.Drawing.Point(12, 125);
            this.lblLoggedInUser.Name = "lblLoggedInUser";
            this.lblLoggedInUser.Size = new System.Drawing.Size(77, 17);
            this.lblLoggedInUser.TabIndex = 8;
            this.lblLoggedInUser.Text = "Username:";
            // 
            // rbImageMedia
            // 
            this.rbImageMedia.AutoSize = true;
            this.rbImageMedia.Location = new System.Drawing.Point(12, 46);
            this.rbImageMedia.Name = "rbImageMedia";
            this.rbImageMedia.Size = new System.Drawing.Size(67, 21);
            this.rbImageMedia.TabIndex = 9;
            this.rbImageMedia.TabStop = true;
            this.rbImageMedia.Text = "Image";
            this.rbImageMedia.UseVisualStyleBackColor = true;
            this.rbImageMedia.CheckedChanged += new System.EventHandler(this.rbImageMedia_CheckedChanged);
            // 
            // rbVideoMedia
            // 
            this.rbVideoMedia.AutoSize = true;
            this.rbVideoMedia.Location = new System.Drawing.Point(12, 19);
            this.rbVideoMedia.Name = "rbVideoMedia";
            this.rbVideoMedia.Size = new System.Drawing.Size(65, 21);
            this.rbVideoMedia.TabIndex = 10;
            this.rbVideoMedia.TabStop = true;
            this.rbVideoMedia.Text = "Video";
            this.rbVideoMedia.UseVisualStyleBackColor = true;
            this.rbVideoMedia.CheckedChanged += new System.EventHandler(this.rbVideoMedia_CheckedChanged);
            // 
            // rbGeenMedia
            // 
            this.rbGeenMedia.AutoSize = true;
            this.rbGeenMedia.Location = new System.Drawing.Point(12, 73);
            this.rbGeenMedia.Name = "rbGeenMedia";
            this.rbGeenMedia.Size = new System.Drawing.Size(106, 21);
            this.rbGeenMedia.TabIndex = 11;
            this.rbGeenMedia.TabStop = true;
            this.rbGeenMedia.Text = "Geen Media";
            this.rbGeenMedia.UseVisualStyleBackColor = true;
            this.rbGeenMedia.CheckedChanged += new System.EventHandler(this.rbGeenMedia_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbGeenMedia);
            this.groupBox1.Controls.Add(this.rbVideoMedia);
            this.groupBox1.Controls.Add(this.rbImageMedia);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Media Opties:";
            // 
            // txtVideoName
            // 
            this.txtVideoName.Location = new System.Drawing.Point(714, 41);
            this.txtVideoName.Name = "txtVideoName";
            this.txtVideoName.Size = new System.Drawing.Size(250, 22);
            this.txtVideoName.TabIndex = 13;
            // 
            // lblVideoName
            // 
            this.lblVideoName.AutoSize = true;
            this.lblVideoName.Location = new System.Drawing.Point(711, 21);
            this.lblVideoName.Name = "lblVideoName";
            this.lblVideoName.Size = new System.Drawing.Size(89, 17);
            this.lblVideoName.TabIndex = 14;
            this.lblVideoName.Text = "Video Name:";
            // 
            // txtVideoLink
            // 
            this.txtVideoLink.Location = new System.Drawing.Point(714, 90);
            this.txtVideoLink.Name = "txtVideoLink";
            this.txtVideoLink.Size = new System.Drawing.Size(250, 22);
            this.txtVideoLink.TabIndex = 15;
            // 
            // lblVideoLink
            // 
            this.lblVideoLink.AutoSize = true;
            this.lblVideoLink.Location = new System.Drawing.Point(711, 70);
            this.lblVideoLink.Name = "lblVideoLink";
            this.lblVideoLink.Size = new System.Drawing.Size(74, 17);
            this.lblVideoLink.TabIndex = 16;
            this.lblVideoLink.Text = "Video Link";
            // 
            // txtImageName
            // 
            this.txtImageName.Location = new System.Drawing.Point(714, 140);
            this.txtImageName.Name = "txtImageName";
            this.txtImageName.Size = new System.Drawing.Size(250, 22);
            this.txtImageName.TabIndex = 17;
            // 
            // lblImageName
            // 
            this.lblImageName.AutoSize = true;
            this.lblImageName.Location = new System.Drawing.Point(711, 120);
            this.lblImageName.Name = "lblImageName";
            this.lblImageName.Size = new System.Drawing.Size(91, 17);
            this.lblImageName.TabIndex = 18;
            this.lblImageName.Text = "Image Name:";
            // 
            // PostPlatform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 593);
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
            this.Name = "PostPlatform";
            this.Text = "PostPlatform";
            this.Load += new System.EventHandler(this.PostPlatform_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}