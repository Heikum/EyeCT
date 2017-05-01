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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation_group));
            this.lbReservationPerson = new System.Windows.Forms.ListBox();
            this.lblReservationPerson = new System.Windows.Forms.Label();
            this.txtReservationName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lbReservationMaterial = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addmaterial = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.residlabel = new System.Windows.Forms.Label();
            this.materiallabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbReservationPerson
            // 
            this.lbReservationPerson.FormattingEnabled = true;
            this.lbReservationPerson.ItemHeight = 25;
            this.lbReservationPerson.Location = new System.Drawing.Point(25, 79);
            this.lbReservationPerson.Margin = new System.Windows.Forms.Padding(6);
            this.lbReservationPerson.Name = "lbReservationPerson";
            this.lbReservationPerson.Size = new System.Drawing.Size(236, 504);
            this.lbReservationPerson.TabIndex = 0;
            this.lbReservationPerson.SelectedIndexChanged += new System.EventHandler(this.lbReservationPerson_SelectedIndexChanged);
            // 
            // lblReservationPerson
            // 
            this.lblReservationPerson.AutoSize = true;
            this.lblReservationPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationPerson.Location = new System.Drawing.Point(18, 36);
            this.lblReservationPerson.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblReservationPerson.Name = "lblReservationPerson";
            this.lblReservationPerson.Size = new System.Drawing.Size(159, 37);
            this.lblReservationPerson.TabIndex = 1;
            this.lblReservationPerson.Text = "Accounts:";
            // 
            // txtReservationName
            // 
            this.txtReservationName.Enabled = false;
            this.txtReservationName.Location = new System.Drawing.Point(25, 620);
            this.txtReservationName.Margin = new System.Windows.Forms.Padding(6);
            this.txtReservationName.Multiline = true;
            this.txtReservationName.Name = "txtReservationName";
            this.txtReservationName.Size = new System.Drawing.Size(229, 31);
            this.txtReservationName.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 664);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add person";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddPerson_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 589);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(28, 720);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(6);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(233, 44);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lbReservationMaterial
            // 
            this.lbReservationMaterial.FormattingEnabled = true;
            this.lbReservationMaterial.ItemHeight = 25;
            this.lbReservationMaterial.Location = new System.Drawing.Point(13, 71);
            this.lbReservationMaterial.Name = "lbReservationMaterial";
            this.lbReservationMaterial.Size = new System.Drawing.Size(230, 504);
            this.lbReservationMaterial.TabIndex = 6;
            this.lbReservationMaterial.SelectedIndexChanged += new System.EventHandler(this.lbReservationMaterial_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Materials:";
            // 
            // addmaterial
            // 
            this.addmaterial.Location = new System.Drawing.Point(13, 581);
            this.addmaterial.Name = "addmaterial";
            this.addmaterial.Size = new System.Drawing.Size(230, 52);
            this.addmaterial.TabIndex = 8;
            this.addmaterial.Text = "Add Material";
            this.addmaterial.UseVisualStyleBackColor = true;
            this.addmaterial.Click += new System.EventHandler(this.addmaterial_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ProftaakEyeCT.Properties.Resources.bar;
            this.pictureBox4.Location = new System.Drawing.Point(13, 845);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(562, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 44;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProftaakEyeCT.Properties.Resources.bar;
            this.pictureBox1.Location = new System.Drawing.Point(13, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(562, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // residlabel
            // 
            this.residlabel.AutoSize = true;
            this.residlabel.Location = new System.Drawing.Point(152, 36);
            this.residlabel.Name = "residlabel";
            this.residlabel.Size = new System.Drawing.Size(59, 25);
            this.residlabel.TabIndex = 46;
            this.residlabel.Text = "resid";
            // 
            // materiallabel
            // 
            this.materiallabel.AutoSize = true;
            this.materiallabel.Location = new System.Drawing.Point(217, 36);
            this.materiallabel.Name = "materiallabel";
            this.materiallabel.Size = new System.Drawing.Size(19, 25);
            this.materiallabel.TabIndex = 47;
            this.materiallabel.Text = "-";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.materiallabel);
            this.groupBox1.Controls.Add(this.lbReservationMaterial);
            this.groupBox1.Controls.Add(this.residlabel);
            this.groupBox1.Controls.Add(this.addmaterial);
            this.groupBox1.Location = new System.Drawing.Point(319, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 772);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbReservationPerson);
            this.groupBox2.Controls.Add(this.lblReservationPerson);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtReservationName);
            this.groupBox2.Controls.Add(this.btnConfirm);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(13, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 772);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            // 
            // Reservation_group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 894);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Reservation_group";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation Details";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button addmaterial;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label residlabel;
        private System.Windows.Forms.Label materiallabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}