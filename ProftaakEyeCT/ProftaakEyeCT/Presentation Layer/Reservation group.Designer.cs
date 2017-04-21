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
            this.SuspendLayout();
            // 
            // lbReservationPerson
            // 
            this.lbReservationPerson.FormattingEnabled = true;
            this.lbReservationPerson.Location = new System.Drawing.Point(12, 42);
            this.lbReservationPerson.Name = "lbReservationPerson";
            this.lbReservationPerson.Size = new System.Drawing.Size(120, 264);
            this.lbReservationPerson.TabIndex = 0;
            this.lbReservationPerson.SelectedIndexChanged += new System.EventHandler(this.lbReservationPerson_SelectedIndexChanged);
            // 
            // lblReservationPerson
            // 
            this.lblReservationPerson.AutoSize = true;
            this.lblReservationPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationPerson.Location = new System.Drawing.Point(12, 19);
            this.lblReservationPerson.Name = "lblReservationPerson";
            this.lblReservationPerson.Size = new System.Drawing.Size(80, 20);
            this.lblReservationPerson.TabIndex = 1;
            this.lblReservationPerson.Text = "Accounts:";
            // 
            // txtReservationName
            // 
            this.txtReservationName.Enabled = false;
            this.txtReservationName.Location = new System.Drawing.Point(153, 70);
            this.txtReservationName.Name = "txtReservationName";
            this.txtReservationName.Size = new System.Drawing.Size(121, 20);
            this.txtReservationName.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add person";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddPerson_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(153, 169);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(121, 23);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // Reservation_group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 318);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtReservationName);
            this.Controls.Add(this.lblReservationPerson);
            this.Controls.Add(this.lbReservationPerson);
            this.Name = "Reservation_group";
            this.Text = "Reservation_group";
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
    }
}