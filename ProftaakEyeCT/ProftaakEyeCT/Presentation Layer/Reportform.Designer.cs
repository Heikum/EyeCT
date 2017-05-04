namespace ProftaakEyeCT.Presentation_Layer
{
    partial class Reportform
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
            this.lbReportedPosts = new System.Windows.Forms.ListBox();
            this.lblReportedPosts = new System.Windows.Forms.Label();
            this.btnReportedPostRemove = new System.Windows.Forms.Button();
            this.wbVideo = new System.Windows.Forms.WebBrowser();
            this.pbMedia = new System.Windows.Forms.PictureBox();
            this.lbReportedPostReactions = new System.Windows.Forms.ListBox();
            this.btnRemoveComplaint = new System.Windows.Forms.Button();
            this.lbComplaints = new System.Windows.Forms.ListBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMedia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbReportedPosts
            // 
            this.lbReportedPosts.FormattingEnabled = true;
            this.lbReportedPosts.Location = new System.Drawing.Point(29, 67);
            this.lbReportedPosts.Name = "lbReportedPosts";
            this.lbReportedPosts.Size = new System.Drawing.Size(213, 303);
            this.lbReportedPosts.TabIndex = 0;
            this.lbReportedPosts.SelectedIndexChanged += new System.EventHandler(this.lbReportedPosts_SelectedIndexChanged);
            // 
            // lblReportedPosts
            // 
            this.lblReportedPosts.AutoSize = true;
            this.lblReportedPosts.Location = new System.Drawing.Point(26, 42);
            this.lblReportedPosts.Name = "lblReportedPosts";
            this.lblReportedPosts.Size = new System.Drawing.Size(82, 13);
            this.lblReportedPosts.TabIndex = 1;
            this.lblReportedPosts.Text = "Reported posts:";
            // 
            // btnReportedPostRemove
            // 
            this.btnReportedPostRemove.Location = new System.Drawing.Point(257, 414);
            this.btnReportedPostRemove.Name = "btnReportedPostRemove";
            this.btnReportedPostRemove.Size = new System.Drawing.Size(244, 23);
            this.btnReportedPostRemove.TabIndex = 2;
            this.btnReportedPostRemove.Text = "Remove Post";
            this.btnReportedPostRemove.UseVisualStyleBackColor = true;
            this.btnReportedPostRemove.Click += new System.EventHandler(this.btnReportedPostRemove_Click);
            // 
            // wbVideo
            // 
            this.wbVideo.Location = new System.Drawing.Point(257, 236);
            this.wbVideo.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbVideo.Name = "wbVideo";
            this.wbVideo.Size = new System.Drawing.Size(244, 172);
            this.wbVideo.TabIndex = 32;
            // 
            // pbMedia
            // 
            this.pbMedia.Location = new System.Drawing.Point(257, 52);
            this.pbMedia.Name = "pbMedia";
            this.pbMedia.Size = new System.Drawing.Size(244, 178);
            this.pbMedia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMedia.TabIndex = 30;
            this.pbMedia.TabStop = false;
            // 
            // lbReportedPostReactions
            // 
            this.lbReportedPostReactions.FormattingEnabled = true;
            this.lbReportedPostReactions.Location = new System.Drawing.Point(507, 67);
            this.lbReportedPostReactions.Name = "lbReportedPostReactions";
            this.lbReportedPostReactions.Size = new System.Drawing.Size(213, 303);
            this.lbReportedPostReactions.TabIndex = 33;
            // 
            // btnRemoveComplaint
            // 
            this.btnRemoveComplaint.Location = new System.Drawing.Point(257, 438);
            this.btnRemoveComplaint.Name = "btnRemoveComplaint";
            this.btnRemoveComplaint.Size = new System.Drawing.Size(244, 23);
            this.btnRemoveComplaint.TabIndex = 35;
            this.btnRemoveComplaint.Text = "Remove complaint";
            this.btnRemoveComplaint.UseVisualStyleBackColor = true;
            this.btnRemoveComplaint.Click += new System.EventHandler(this.btnRemoveComplaint_Click);
            // 
            // lbComplaints
            // 
            this.lbComplaints.FormattingEnabled = true;
            this.lbComplaints.Location = new System.Drawing.Point(29, 376);
            this.lbComplaints.Name = "lbComplaints";
            this.lbComplaints.Size = new System.Drawing.Size(213, 95);
            this.lbComplaints.TabIndex = 36;
            // 
            // pictureBox20
            // 
            this.pictureBox20.Image = global::ProftaakEyeCT.Properties.Resources.bar;
            this.pictureBox20.Location = new System.Drawing.Point(0, 2);
            this.pictureBox20.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(728, 19);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox20.TabIndex = 37;
            this.pictureBox20.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProftaakEyeCT.Properties.Resources.bar;
            this.pictureBox1.Location = new System.Drawing.Point(0, 476);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(728, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // Reportform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 493);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox20);
            this.Controls.Add(this.lbComplaints);
            this.Controls.Add(this.btnRemoveComplaint);
            this.Controls.Add(this.lbReportedPostReactions);
            this.Controls.Add(this.wbVideo);
            this.Controls.Add(this.pbMedia);
            this.Controls.Add(this.btnReportedPostRemove);
            this.Controls.Add(this.lblReportedPosts);
            this.Controls.Add(this.lbReportedPosts);
            this.Name = "Reportform";
            this.Text = "Reportform";
            ((System.ComponentModel.ISupportInitialize)(this.pbMedia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbReportedPosts;
        private System.Windows.Forms.Label lblReportedPosts;
        private System.Windows.Forms.Button btnReportedPostRemove;
        private System.Windows.Forms.WebBrowser wbVideo;
        private System.Windows.Forms.PictureBox pbMedia;
        private System.Windows.Forms.ListBox lbReportedPostReactions;
        private System.Windows.Forms.Button btnRemoveComplaint;
        private System.Windows.Forms.ListBox lbComplaints;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}