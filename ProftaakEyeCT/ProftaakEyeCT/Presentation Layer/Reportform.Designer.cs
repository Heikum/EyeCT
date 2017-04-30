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
            this.txtReportedPostComplaint = new System.Windows.Forms.TextBox();
            this.btnRemoveComplaint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMedia)).BeginInit();
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
            // txtReportedPostComplaint
            // 
            this.txtReportedPostComplaint.Location = new System.Drawing.Point(29, 376);
            this.txtReportedPostComplaint.Multiline = true;
            this.txtReportedPostComplaint.Name = "txtReportedPostComplaint";
            this.txtReportedPostComplaint.Size = new System.Drawing.Size(213, 61);
            this.txtReportedPostComplaint.TabIndex = 34;
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
            // Reportform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 473);
            this.Controls.Add(this.btnRemoveComplaint);
            this.Controls.Add(this.txtReportedPostComplaint);
            this.Controls.Add(this.lbReportedPostReactions);
            this.Controls.Add(this.wbVideo);
            this.Controls.Add(this.pbMedia);
            this.Controls.Add(this.btnReportedPostRemove);
            this.Controls.Add(this.lblReportedPosts);
            this.Controls.Add(this.lbReportedPosts);
            this.Name = "Reportform";
            this.Text = "Reportform";
            ((System.ComponentModel.ISupportInitialize)(this.pbMedia)).EndInit();
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
        private System.Windows.Forms.TextBox txtReportedPostComplaint;
        private System.Windows.Forms.Button btnRemoveComplaint;
    }
}