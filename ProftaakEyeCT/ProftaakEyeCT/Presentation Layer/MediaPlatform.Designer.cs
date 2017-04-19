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
            this.lblMediaPosts = new System.Windows.Forms.Label();
            this.btnMediaVerwijderen = new System.Windows.Forms.Button();
            this.btnMediaRefresh = new System.Windows.Forms.Button();
            this.lbMediaReactions = new System.Windows.Forms.ListBox();
            this.lbMediaPosts = new System.Windows.Forms.ListBox();
            this.btnMediaRapporteren = new System.Windows.Forms.Button();
            this.btnMediaAanpassen = new System.Windows.Forms.Button();
            this.btnMediaReageren = new System.Windows.Forms.Button();
            this.lblMediaReacties = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMediaPosts
            // 
            this.lblMediaPosts.AutoSize = true;
            this.lblMediaPosts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMediaPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediaPosts.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblMediaPosts.Location = new System.Drawing.Point(110, 19);
            this.lblMediaPosts.Margin = new System.Windows.Forms.Padding(30, 10, 10, 0);
            this.lblMediaPosts.Name = "lblMediaPosts";
            this.lblMediaPosts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMediaPosts.Size = new System.Drawing.Size(61, 25);
            this.lblMediaPosts.TabIndex = 8;
            this.lblMediaPosts.Text = "Posts";
            this.lblMediaPosts.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnMediaVerwijderen
            // 
            this.btnMediaVerwijderen.Location = new System.Drawing.Point(397, 438);
            this.btnMediaVerwijderen.Name = "btnMediaVerwijderen";
            this.btnMediaVerwijderen.Size = new System.Drawing.Size(107, 40);
            this.btnMediaVerwijderen.TabIndex = 2;
            this.btnMediaVerwijderen.Text = "Verwijderen";
            this.btnMediaVerwijderen.UseVisualStyleBackColor = true;
            // 
            // btnMediaRefresh
            // 
            this.btnMediaRefresh.Location = new System.Drawing.Point(251, 438);
            this.btnMediaRefresh.Name = "btnMediaRefresh";
            this.btnMediaRefresh.Size = new System.Drawing.Size(128, 40);
            this.btnMediaRefresh.TabIndex = 4;
            this.btnMediaRefresh.Text = "Refresh";
            this.btnMediaRefresh.UseVisualStyleBackColor = true;
            // 
            // lbMediaReactions
            // 
            this.lbMediaReactions.FormattingEnabled = true;
            this.lbMediaReactions.Location = new System.Drawing.Point(414, 64);
            this.lbMediaReactions.Name = "lbMediaReactions";
            this.lbMediaReactions.Size = new System.Drawing.Size(378, 368);
            this.lbMediaReactions.TabIndex = 6;
            // 
            // lbMediaPosts
            // 
            this.lbMediaPosts.FormattingEnabled = true;
            this.lbMediaPosts.HorizontalScrollbar = true;
            this.lbMediaPosts.Location = new System.Drawing.Point(12, 64);
            this.lbMediaPosts.Name = "lbMediaPosts";
            this.lbMediaPosts.Size = new System.Drawing.Size(380, 368);
            this.lbMediaPosts.TabIndex = 5;
            this.lbMediaPosts.SelectedIndexChanged += new System.EventHandler(this.lbMediaPosts_SelectedIndexChanged);
            // 
            // btnMediaRapporteren
            // 
            this.btnMediaRapporteren.Location = new System.Drawing.Point(510, 438);
            this.btnMediaRapporteren.Name = "btnMediaRapporteren";
            this.btnMediaRapporteren.Size = new System.Drawing.Size(107, 40);
            this.btnMediaRapporteren.TabIndex = 3;
            this.btnMediaRapporteren.Text = "Rapporteren";
            this.btnMediaRapporteren.UseVisualStyleBackColor = true;
            // 
            // btnMediaAanpassen
            // 
            this.btnMediaAanpassen.Location = new System.Drawing.Point(12, 438);
            this.btnMediaAanpassen.Name = "btnMediaAanpassen";
            this.btnMediaAanpassen.Size = new System.Drawing.Size(107, 40);
            this.btnMediaAanpassen.TabIndex = 1;
            this.btnMediaAanpassen.Text = "Aanpassen";
            this.btnMediaAanpassen.UseVisualStyleBackColor = true;
            // 
            // btnMediaReageren
            // 
            this.btnMediaReageren.Location = new System.Drawing.Point(125, 438);
            this.btnMediaReageren.Name = "btnMediaReageren";
            this.btnMediaReageren.Size = new System.Drawing.Size(107, 40);
            this.btnMediaReageren.TabIndex = 0;
            this.btnMediaReageren.Text = "Reageren";
            this.btnMediaReageren.UseVisualStyleBackColor = true;
            // 
            // lblMediaReacties
            // 
            this.lblMediaReacties.AutoSize = true;
            this.lblMediaReacties.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediaReacties.Location = new System.Drawing.Point(483, 19);
            this.lblMediaReacties.Name = "lblMediaReacties";
            this.lblMediaReacties.Size = new System.Drawing.Size(87, 25);
            this.lblMediaReacties.TabIndex = 9;
            this.lblMediaReacties.Text = "Reacties";
            // 
            // MediaPlatform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(804, 490);
            this.Controls.Add(this.lblMediaReacties);
            this.Controls.Add(this.btnMediaVerwijderen);
            this.Controls.Add(this.btnMediaRapporteren);
            this.Controls.Add(this.btnMediaAanpassen);
            this.Controls.Add(this.btnMediaRefresh);
            this.Controls.Add(this.lbMediaReactions);
            this.Controls.Add(this.btnMediaReageren);
            this.Controls.Add(this.lbMediaPosts);
            this.Controls.Add(this.lblMediaPosts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MediaPlatform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MediaPlatform";
            this.Load += new System.EventHandler(this.MediaPlatform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMediaPosts;
        private System.Windows.Forms.Button btnMediaVerwijderen;
        private System.Windows.Forms.Button btnMediaRefresh;
        private System.Windows.Forms.ListBox lbMediaReactions;
        private System.Windows.Forms.ListBox lbMediaPosts;
        private System.Windows.Forms.Button btnMediaRapporteren;
        private System.Windows.Forms.Button btnMediaAanpassen;
        private System.Windows.Forms.Button btnMediaReageren;
        private System.Windows.Forms.Label lblMediaReacties;
    }
}