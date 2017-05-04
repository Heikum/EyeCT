namespace ProftaakEyeCT.Presentation_Layer
{
    partial class ReportComplaint
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
            this.txtReportComplaint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnComplaintSend = new System.Windows.Forms.Button();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtReportComplaint
            // 
            this.txtReportComplaint.Location = new System.Drawing.Point(25, 46);
            this.txtReportComplaint.Multiline = true;
            this.txtReportComplaint.Name = "txtReportComplaint";
            this.txtReportComplaint.Size = new System.Drawing.Size(247, 64);
            this.txtReportComplaint.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Complaint:";
            // 
            // btnComplaintSend
            // 
            this.btnComplaintSend.Location = new System.Drawing.Point(164, 116);
            this.btnComplaintSend.Name = "btnComplaintSend";
            this.btnComplaintSend.Size = new System.Drawing.Size(108, 23);
            this.btnComplaintSend.TabIndex = 2;
            this.btnComplaintSend.Text = "Commit complaint";
            this.btnComplaintSend.UseVisualStyleBackColor = true;
            this.btnComplaintSend.Click += new System.EventHandler(this.btnComplaintSend_Click);
            // 
            // pictureBox20
            // 
            this.pictureBox20.Image = global::ProftaakEyeCT.Properties.Resources.bar;
            this.pictureBox20.Location = new System.Drawing.Point(0, -1);
            this.pictureBox20.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(283, 19);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox20.TabIndex = 27;
            this.pictureBox20.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProftaakEyeCT.Properties.Resources.bar;
            this.pictureBox1.Location = new System.Drawing.Point(0, 144);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // ReportComplaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 166);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox20);
            this.Controls.Add(this.btnComplaintSend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReportComplaint);
            this.Name = "ReportComplaint";
            this.Text = "ReportComplaint";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReportComplaint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnComplaintSend;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}