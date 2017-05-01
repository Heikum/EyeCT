namespace ProftaakEyeCT.Presentation_Layer
{
    partial class Reservation_group
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
            this.lbReservationPerson = new System.Windows.Forms.ListBox();
            this.lblReservationPerson = new System.Windows.Forms.Label();
            this.txtReservationName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lbReservationMaterial = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbReservationPerson
            // 
            this.lbReservationPerson.FormattingEnabled = true;
            this.lbReservationPerson.ItemHeight = 25;
            this.lbReservationPerson.Location = new System.Drawing.Point(24, 81);
            this.lbReservationPerson.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lbReservationPerson.Name = "lbReservationPerson";
            this.lbReservationPerson.Size = new System.Drawing.Size(236, 504);
            this.lbReservationPerson.TabIndex = 0;
            this.lbReservationPerson.SelectedIndexChanged += new System.EventHandler(this.lbReservationPerson_SelectedIndexChanged);
            // 
            // lblReservationPerson
            // 
            this.lblReservationPerson.AutoSize = true;
            this.lblReservationPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationPerson.Location = new System.Drawing.Point(24, 37);
            this.lblReservationPerson.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblReservationPerson.Name = "lblReservationPerson";
            this.lblReservationPerson.Size = new System.Drawing.Size(159, 37);
            this.lblReservationPerson.TabIndex = 1;
            this.lblReservationPerson.Text = "Accounts:";
            // 
            // txtReservationName
            // 
            this.txtReservationName.Enabled = false;
            this.txtReservationName.Location = new System.Drawing.Point(295, 122);
            this.txtReservationName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtReservationName.Name = "txtReservationName";
            this.txtReservationName.Size = new System.Drawing.Size(238, 31);
            this.txtReservationName.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 165);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add person";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddPerson_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(291, 221);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(242, 44);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lbReservationMaterial
            // 
            this.lbReservationMaterial.FormattingEnabled = true;
            this.lbReservationMaterial.ItemHeight = 25;
            this.lbReservationMaterial.Location = new System.Drawing.Point(665, 92);
            this.lbReservationMaterial.Name = "lbReservationMaterial";
            this.lbReservationMaterial.Size = new System.Drawing.Size(230, 504);
            this.lbReservationMaterial.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(660, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Materials:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(934, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 52);
            this.button2.TabIndex = 8;
            this.button2.Text = "Add Material";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Reservation_group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 691);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbReservationMaterial);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtReservationName);
            this.Controls.Add(this.lblReservationPerson);
            this.Controls.Add(this.lbReservationPerson);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "Reservation_group";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbReservationPerson;
        private System.Windows.Forms.Label lblReservationPerson;
        private System.Windows.Forms.TextBox txtReservationName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ListBox lbReservationMaterial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}