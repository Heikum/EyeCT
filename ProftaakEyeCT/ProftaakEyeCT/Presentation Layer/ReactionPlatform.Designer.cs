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
            this.txtUsername.Location = new System.Drawing.Point(12, 29);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(231, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // txtReactionText
            // 
            this.txtReactionText.Location = new System.Drawing.Point(12, 72);
            this.txtReactionText.Name = "txtReactionText";
            this.txtReactionText.Size = new System.Drawing.Size(231, 20);
            this.txtReactionText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Text";
            // 
            // txtReactionID
            // 
            this.txtReactionID.Location = new System.Drawing.Point(12, 112);
            this.txtReactionID.Name = "txtReactionID";
            this.txtReactionID.Size = new System.Drawing.Size(231, 20);
            this.txtReactionID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ReactionID";
            // 
            // btnAddReaction
            // 
            this.btnAddReaction.Location = new System.Drawing.Point(12, 155);
            this.btnAddReaction.Name = "btnAddReaction";
            this.btnAddReaction.Size = new System.Drawing.Size(75, 23);
            this.btnAddReaction.TabIndex = 7;
            this.btnAddReaction.Text = "Add";
            this.btnAddReaction.UseVisualStyleBackColor = true;
            this.btnAddReaction.Click += new System.EventHandler(this.btnAddReaction_Click);
            // 
            // ReactionPlatform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 190);
            this.Controls.Add(this.btnAddReaction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtReactionID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReactionText);
            this.Controls.Add(this.txtUsername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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