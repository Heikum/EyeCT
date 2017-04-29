namespace ProftaakEyeCT
{
    partial class MediaPlatform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaPlatform));
            this.btnMediaVerwijderen = new System.Windows.Forms.Button();
            this.btnMediaRefresh = new System.Windows.Forms.Button();
            this.lbMediaReactions = new System.Windows.Forms.ListBox();
            this.lbMediaPosts = new System.Windows.Forms.ListBox();
            this.btnMediaRapporteren = new System.Windows.Forms.Button();
            this.btnMediaAanpassen = new System.Windows.Forms.Button();
            this.btnMediaReageren = new System.Windows.Forms.Button();
            this.btnOpenPostPlatform = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pbMedia = new System.Windows.Forms.PictureBox();
            this.btnLoadMedia = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMedia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMediaVerwijderen
            // 
            this.btnMediaVerwijderen.Location = new System.Drawing.Point(556, 514);
            this.btnMediaVerwijderen.Name = "btnMediaVerwijderen";
            this.btnMediaVerwijderen.Size = new System.Drawing.Size(107, 40);
            this.btnMediaVerwijderen.TabIndex = 2;
            this.btnMediaVerwijderen.Text = "Verwijderen";
            this.btnMediaVerwijderen.UseVisualStyleBackColor = true;
            this.btnMediaVerwijderen.Click += new System.EventHandler(this.btnMediaVerwijderen_Click);
            // 
            // btnMediaRefresh
            // 
            this.btnMediaRefresh.Location = new System.Drawing.Point(416, 514);
            this.btnMediaRefresh.Name = "btnMediaRefresh";
            this.btnMediaRefresh.Size = new System.Drawing.Size(128, 40);
            this.btnMediaRefresh.TabIndex = 4;
            this.btnMediaRefresh.Text = "Refresh";
            this.btnMediaRefresh.UseVisualStyleBackColor = true;
            this.btnMediaRefresh.Click += new System.EventHandler(this.btnMediaRefresh_Click);
            // 
            // lbMediaReactions
            // 
            this.lbMediaReactions.FormattingEnabled = true;
            this.lbMediaReactions.Location = new System.Drawing.Point(591, 155);
            this.lbMediaReactions.Name = "lbMediaReactions";
            this.lbMediaReactions.Size = new System.Drawing.Size(203, 355);
            this.lbMediaReactions.TabIndex = 6;
            // 
            // lbMediaPosts
            // 
            this.lbMediaPosts.FormattingEnabled = true;
            this.lbMediaPosts.HorizontalScrollbar = true;
            this.lbMediaPosts.Location = new System.Drawing.Point(14, 155);
            this.lbMediaPosts.Name = "lbMediaPosts";
            this.lbMediaPosts.Size = new System.Drawing.Size(321, 355);
            this.lbMediaPosts.TabIndex = 5;
            this.lbMediaPosts.SelectedIndexChanged += new System.EventHandler(this.lbMediaPosts_SelectedIndexChanged);
            // 
            // btnMediaRapporteren
            // 
            this.btnMediaRapporteren.Location = new System.Drawing.Point(684, 514);
            this.btnMediaRapporteren.Name = "btnMediaRapporteren";
            this.btnMediaRapporteren.Size = new System.Drawing.Size(107, 40);
            this.btnMediaRapporteren.TabIndex = 3;
            this.btnMediaRapporteren.Text = "Rapporteren";
            this.btnMediaRapporteren.UseVisualStyleBackColor = true;
            // 
            // btnMediaAanpassen
            // 
            this.btnMediaAanpassen.Location = new System.Drawing.Point(14, 516);
            this.btnMediaAanpassen.Name = "btnMediaAanpassen";
            this.btnMediaAanpassen.Size = new System.Drawing.Size(107, 40);
            this.btnMediaAanpassen.TabIndex = 1;
            this.btnMediaAanpassen.Text = "Aanpassen";
            this.btnMediaAanpassen.UseVisualStyleBackColor = true;
            // 
            // btnMediaReageren
            // 
            this.btnMediaReageren.Location = new System.Drawing.Point(286, 514);
            this.btnMediaReageren.Name = "btnMediaReageren";
            this.btnMediaReageren.Size = new System.Drawing.Size(107, 40);
            this.btnMediaReageren.TabIndex = 0;
            this.btnMediaReageren.Text = "Reageren";
            this.btnMediaReageren.UseVisualStyleBackColor = true;
            this.btnMediaReageren.Click += new System.EventHandler(this.btnMediaReageren_Click);
            // 
            // btnOpenPostPlatform
            // 
            this.btnOpenPostPlatform.Location = new System.Drawing.Point(152, 516);
            this.btnOpenPostPlatform.Name = "btnOpenPostPlatform";
            this.btnOpenPostPlatform.Size = new System.Drawing.Size(107, 40);
            this.btnOpenPostPlatform.TabIndex = 10;
            this.btnOpenPostPlatform.Text = "Nieuwe Post";
            this.btnOpenPostPlatform.UseVisualStyleBackColor = true;
            this.btnOpenPostPlatform.Click += new System.EventHandler(this.btnOpenPostPlatform_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ProftaakEyeCT.Properties.Resources.reactions;
            this.pictureBox4.Location = new System.Drawing.Point(604, 93);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(175, 57);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProftaakEyeCT.Properties.Resources.Posts;
            this.pictureBox3.Location = new System.Drawing.Point(88, 93);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(136, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProftaakEyeCT.Properties.Resources.mediaplatform;
            this.pictureBox2.Location = new System.Drawing.Point(228, -11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(412, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProftaakEyeCT.Properties.Resources.bar;
            this.pictureBox1.Location = new System.Drawing.Point(6, 73);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(796, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::ProftaakEyeCT.Properties.Resources.bar;
            this.pictureBox7.Location = new System.Drawing.Point(6, 560);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(796, 19);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 20;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ProftaakEyeCT.Properties.Resources.logo1;
            this.pictureBox5.Location = new System.Drawing.Point(660, 6);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(62, 63);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            // 
            // pbMedia
            // 
            this.pbMedia.Location = new System.Drawing.Point(341, 155);
            this.pbMedia.Name = "pbMedia";
            this.pbMedia.Size = new System.Drawing.Size(244, 178);
            this.pbMedia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMedia.TabIndex = 26;
            this.pbMedia.TabStop = false;
            // 
            // btnLoadMedia
            // 
            this.btnLoadMedia.Location = new System.Drawing.Point(341, 126);
            this.btnLoadMedia.Name = "btnLoadMedia";
            this.btnLoadMedia.Size = new System.Drawing.Size(75, 23);
            this.btnLoadMedia.TabIndex = 28;
            this.btnLoadMedia.Text = "Load Media";
            this.btnLoadMedia.UseVisualStyleBackColor = true;
            this.btnLoadMedia.Click += new System.EventHandler(this.btnLoadMedia_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(341, 336);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(218, 172);
            this.webBrowser1.TabIndex = 29;
            // 
            // MediaPlatform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(805, 595);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnLoadMedia);
            this.Controls.Add(this.pbMedia);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.btnOpenPostPlatform);
            this.Controls.Add(this.btnMediaVerwijderen);
            this.Controls.Add(this.btnMediaRapporteren);
            this.Controls.Add(this.btnMediaAanpassen);
            this.Controls.Add(this.btnMediaRefresh);
            this.Controls.Add(this.lbMediaReactions);
            this.Controls.Add(this.btnMediaReageren);
            this.Controls.Add(this.lbMediaPosts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MediaPlatform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Platform";
            this.Load += new System.EventHandler(this.MediaPlatform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMedia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMediaVerwijderen;
        private System.Windows.Forms.Button btnMediaRefresh;
        private System.Windows.Forms.ListBox lbMediaReactions;
        private System.Windows.Forms.ListBox lbMediaPosts;
        private System.Windows.Forms.Button btnMediaRapporteren;
        private System.Windows.Forms.Button btnMediaAanpassen;
        private System.Windows.Forms.Button btnMediaReageren;
        private System.Windows.Forms.Button btnOpenPostPlatform;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pbMedia;
        private System.Windows.Forms.Button btnLoadMedia;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}