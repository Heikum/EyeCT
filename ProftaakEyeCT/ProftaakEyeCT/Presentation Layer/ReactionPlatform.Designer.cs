namespace ProftaakEyeCT.Presentation_Layer
{
    partial class ReactionPlatform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReactionPlatform));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtReactionText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReactionID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddReaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(16, 36);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(307, 22);
            this.txtUsername.TabIndex = 0;
            // 
            // txtReactionText
            // 
            this.txtReactionText.Location = new System.Drawing.Point(16, 89);
            this.txtReactionText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReactionText.Name = "txtReactionText";
            this.txtReactionText.Size = new System.Drawing.Size(307, 22);
            this.txtReactionText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Text";
            // 
            // txtReactionID
            // 
            this.txtReactionID.Location = new System.Drawing.Point(16, 138);
            this.txtReactionID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReactionID.Name = "txtReactionID";
            this.txtReactionID.Size = new System.Drawing.Size(307, 22);
            this.txtReactionID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "ReactionID";
            // 
            // btnAddReaction
            // 
            this.btnAddReaction.Location = new System.Drawing.Point(16, 191);
            this.btnAddReaction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddReaction.Name = "btnAddReaction";
            this.btnAddReaction.Size = new System.Drawing.Size(100, 28);
            this.btnAddReaction.TabIndex = 7;
            this.btnAddReaction.Text = "Add";
            this.btnAddReaction.UseVisualStyleBackColor = true;
            this.btnAddReaction.Click += new System.EventHandler(this.btnAddReaction_Click);
            // 
            // ReactionPlatform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 234);
            this.Controls.Add(this.btnAddReaction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtReactionID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReactionText);
            this.Controls.Add(this.txtUsername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReactionPlatform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReactionPlatform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtReactionText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReactionID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddReaction;
    }
}