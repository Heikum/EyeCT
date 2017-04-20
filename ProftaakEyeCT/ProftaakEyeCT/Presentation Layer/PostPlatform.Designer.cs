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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtPostMediaLink = new System.Windows.Forms.TextBox();
            this.lblPostMediaLink = new System.Windows.Forms.Label();
            this.btnAddPost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPostPlatformPosts
            // 
            this.lbPostPlatformPosts.FormattingEnabled = true;
            this.lbPostPlatformPosts.ItemHeight = 16;
            this.lbPostPlatformPosts.Location = new System.Drawing.Point(631, 43);
            this.lbPostPlatformPosts.Name = "lbPostPlatformPosts";
            this.lbPostPlatformPosts.Size = new System.Drawing.Size(338, 420);
            this.lbPostPlatformPosts.TabIndex = 0;
            // 
            // txtPostPlatformText
            // 
            this.txtPostPlatformText.Location = new System.Drawing.Point(12, 43);
            this.txtPostPlatformText.Multiline = true;
            this.txtPostPlatformText.Name = "txtPostPlatformText";
            this.txtPostPlatformText.Size = new System.Drawing.Size(240, 121);
            this.txtPostPlatformText.TabIndex = 1;
            // 
            // lblPostPlatformText
            // 
            this.lblPostPlatformText.AutoSize = true;
            this.lblPostPlatformText.Location = new System.Drawing.Point(9, 23);
            this.lblPostPlatformText.Name = "lblPostPlatformText";
            this.lblPostPlatformText.Size = new System.Drawing.Size(71, 17);
            this.lblPostPlatformText.TabIndex = 2;
            this.lblPostPlatformText.Text = "Post Text:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 219);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(249, 22);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2017, 4, 20, 11, 46, 15, 0);
            // 
            // txtPostMediaLink
            // 
            this.txtPostMediaLink.Location = new System.Drawing.Point(12, 191);
            this.txtPostMediaLink.Name = "txtPostMediaLink";
            this.txtPostMediaLink.Size = new System.Drawing.Size(240, 22);
            this.txtPostMediaLink.TabIndex = 4;
            // 
            // lblPostMediaLink
            // 
            this.lblPostMediaLink.AutoSize = true;
            this.lblPostMediaLink.Location = new System.Drawing.Point(9, 171);
            this.lblPostMediaLink.Name = "lblPostMediaLink";
            this.lblPostMediaLink.Size = new System.Drawing.Size(80, 17);
            this.lblPostMediaLink.TabIndex = 5;
            this.lblPostMediaLink.Text = "Media Link:";
            // 
            // btnAddPost
            // 
            this.btnAddPost.Location = new System.Drawing.Point(12, 264);
            this.btnAddPost.Name = "btnAddPost";
            this.btnAddPost.Size = new System.Drawing.Size(259, 30);
            this.btnAddPost.TabIndex = 6;
            this.btnAddPost.Text = "Place Post";
            this.btnAddPost.UseVisualStyleBackColor = true;
            this.btnAddPost.Click += new System.EventHandler(this.btnAddPost_Click);
            // 
            // PostPlatform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 593);
            this.Controls.Add(this.btnAddPost);
            this.Controls.Add(this.lblPostMediaLink);
            this.Controls.Add(this.txtPostMediaLink);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblPostPlatformText);
            this.Controls.Add(this.txtPostPlatformText);
            this.Controls.Add(this.lbPostPlatformPosts);
            this.Name = "PostPlatform";
            this.Text = "PostPlatform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPostPlatformPosts;
        private System.Windows.Forms.TextBox txtPostPlatformText;
        private System.Windows.Forms.Label lblPostPlatformText;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtPostMediaLink;
        private System.Windows.Forms.Label lblPostMediaLink;
        private System.Windows.Forms.Button btnAddPost;
    }
}