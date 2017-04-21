namespace ProftaakEyeCT.Presentation_Layer
{
    partial class EventPlatform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventPlatform));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEventRemove = new System.Windows.Forms.Button();
            this.lbAllEvents = new System.Windows.Forms.ListBox();
            this.btnEventUpdate = new System.Windows.Forms.Button();
            this.btnEventEdit = new System.Windows.Forms.Button();
            this.lblEventStartDate = new System.Windows.Forms.Label();
            this.lblEventLocation = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblEventDescription = new System.Windows.Forms.Label();
            this.txtEventLocation = new System.Windows.Forms.TextBox();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.txtEventDescription = new System.Windows.Forms.TextBox();
            this.dtpEventStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEventEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEventEndDate = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnEventAdd = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEventRemove);
            this.groupBox1.Controls.Add(this.lbAllEvents);
            this.groupBox1.Controls.Add(this.btnEventUpdate);
            this.groupBox1.Controls.Add(this.btnEventEdit);
            this.groupBox1.Location = new System.Drawing.Point(531, 241);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(842, 706);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // btnEventRemove
            // 
            this.btnEventRemove.Enabled = false;
            this.btnEventRemove.Location = new System.Drawing.Point(590, 650);
            this.btnEventRemove.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEventRemove.Name = "btnEventRemove";
            this.btnEventRemove.Size = new System.Drawing.Size(240, 44);
            this.btnEventRemove.TabIndex = 16;
            this.btnEventRemove.Text = "Remove";
            this.btnEventRemove.UseVisualStyleBackColor = true;
            this.btnEventRemove.Click += new System.EventHandler(this.btnEventRemove_Click);
            // 
            // lbAllEvents
            // 
            this.lbAllEvents.FormattingEnabled = true;
            this.lbAllEvents.ItemHeight = 25;
            this.lbAllEvents.Location = new System.Drawing.Point(12, 35);
            this.lbAllEvents.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lbAllEvents.Name = "lbAllEvents";
            this.lbAllEvents.Size = new System.Drawing.Size(816, 554);
            this.lbAllEvents.TabIndex = 13;
            this.lbAllEvents.SelectedIndexChanged += new System.EventHandler(this.lbAllEvents_SelectedIndexChanged);
            // 
            // btnEventUpdate
            // 
            this.btnEventUpdate.Enabled = false;
            this.btnEventUpdate.Location = new System.Drawing.Point(590, 604);
            this.btnEventUpdate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEventUpdate.Name = "btnEventUpdate";
            this.btnEventUpdate.Size = new System.Drawing.Size(240, 44);
            this.btnEventUpdate.TabIndex = 15;
            this.btnEventUpdate.Text = "Update";
            this.btnEventUpdate.UseVisualStyleBackColor = true;
            this.btnEventUpdate.Click += new System.EventHandler(this.btnEventUpdate_Click);
            // 
            // btnEventEdit
            // 
            this.btnEventEdit.Enabled = false;
            this.btnEventEdit.Location = new System.Drawing.Point(12, 627);
            this.btnEventEdit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEventEdit.Name = "btnEventEdit";
            this.btnEventEdit.Size = new System.Drawing.Size(246, 44);
            this.btnEventEdit.TabIndex = 14;
            this.btnEventEdit.Text = "Edit";
            this.btnEventEdit.UseVisualStyleBackColor = true;
            this.btnEventEdit.Click += new System.EventHandler(this.btnEventEdit_Click);
            // 
            // lblEventStartDate
            // 
            this.lblEventStartDate.AutoSize = true;
            this.lblEventStartDate.Location = new System.Drawing.Point(61, 564);
            this.lblEventStartDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEventStartDate.Name = "lblEventStartDate";
            this.lblEventStartDate.Size = new System.Drawing.Size(114, 25);
            this.lblEventStartDate.TabIndex = 32;
            this.lblEventStartDate.Text = "Start Date:";
            // 
            // lblEventLocation
            // 
            this.lblEventLocation.AutoSize = true;
            this.lblEventLocation.Location = new System.Drawing.Point(61, 480);
            this.lblEventLocation.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEventLocation.Name = "lblEventLocation";
            this.lblEventLocation.Size = new System.Drawing.Size(100, 25);
            this.lblEventLocation.TabIndex = 31;
            this.lblEventLocation.Text = "Location:";
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Location = new System.Drawing.Point(61, 399);
            this.lblEventName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(74, 25);
            this.lblEventName.TabIndex = 30;
            this.lblEventName.Text = "Name:";
            // 
            // lblEventDescription
            // 
            this.lblEventDescription.AutoSize = true;
            this.lblEventDescription.Location = new System.Drawing.Point(61, 276);
            this.lblEventDescription.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEventDescription.Name = "lblEventDescription";
            this.lblEventDescription.Size = new System.Drawing.Size(126, 25);
            this.lblEventDescription.TabIndex = 29;
            this.lblEventDescription.Text = "Description:";
            // 
            // txtEventLocation
            // 
            this.txtEventLocation.Location = new System.Drawing.Point(61, 512);
            this.txtEventLocation.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtEventLocation.Name = "txtEventLocation";
            this.txtEventLocation.Size = new System.Drawing.Size(236, 31);
            this.txtEventLocation.TabIndex = 26;
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(61, 426);
            this.txtEventName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(236, 31);
            this.txtEventName.TabIndex = 25;
            // 
            // txtEventDescription
            // 
            this.txtEventDescription.Location = new System.Drawing.Point(61, 312);
            this.txtEventDescription.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtEventDescription.Multiline = true;
            this.txtEventDescription.Name = "txtEventDescription";
            this.txtEventDescription.Size = new System.Drawing.Size(334, 77);
            this.txtEventDescription.TabIndex = 24;
            // 
            // dtpEventStartDate
            // 
            this.dtpEventStartDate.Checked = false;
            this.dtpEventStartDate.Location = new System.Drawing.Point(61, 595);
            this.dtpEventStartDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpEventStartDate.Name = "dtpEventStartDate";
            this.dtpEventStartDate.Size = new System.Drawing.Size(334, 31);
            this.dtpEventStartDate.TabIndex = 17;
            // 
            // dtpEventEndDate
            // 
            this.dtpEventEndDate.Checked = false;
            this.dtpEventEndDate.Location = new System.Drawing.Point(61, 682);
            this.dtpEventEndDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpEventEndDate.Name = "dtpEventEndDate";
            this.dtpEventEndDate.Size = new System.Drawing.Size(334, 31);
            this.dtpEventEndDate.TabIndex = 36;
            // 
            // lblEventEndDate
            // 
            this.lblEventEndDate.AutoSize = true;
            this.lblEventEndDate.Location = new System.Drawing.Point(61, 651);
            this.lblEventEndDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEventEndDate.Name = "lblEventEndDate";
            this.lblEventEndDate.Size = new System.Drawing.Size(107, 25);
            this.lblEventEndDate.TabIndex = 37;
            this.lblEventEndDate.Text = "End Date:";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(61, 824);
            this.btnTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(334, 37);
            this.btnTest.TabIndex = 38;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnEventAdd
            // 
            this.btnEventAdd.Location = new System.Drawing.Point(61, 755);
            this.btnEventAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEventAdd.Name = "btnEventAdd";
            this.btnEventAdd.Size = new System.Drawing.Size(338, 44);
            this.btnEventAdd.TabIndex = 39;
            this.btnEventAdd.Text = "Add event";
            this.btnEventAdd.UseVisualStyleBackColor = true;
            this.btnEventAdd.Click += new System.EventHandler(this.btnEventAdd_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProftaakEyeCT.Properties.Resources.events;
            this.pictureBox2.Location = new System.Drawing.Point(424, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(586, 134);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProftaakEyeCT.Properties.Resources.bar;
            this.pictureBox1.Location = new System.Drawing.Point(-5, 957);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1409, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::ProftaakEyeCT.Properties.Resources.bar;
            this.pictureBox6.Location = new System.Drawing.Point(-5, 156);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(1409, 37);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 40;
            this.pictureBox6.TabStop = false;
            // 
            // EventPlatform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1402, 1000);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.btnEventAdd);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.dtpEventEndDate);
            this.Controls.Add(this.lblEventEndDate);
            this.Controls.Add(this.dtpEventStartDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblEventStartDate);
            this.Controls.Add(this.lblEventLocation);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.lblEventDescription);
            this.Controls.Add(this.txtEventLocation);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.txtEventDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EventPlatform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Platform";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEventRemove;
        private System.Windows.Forms.ListBox lbAllEvents;
        private System.Windows.Forms.Button btnEventUpdate;
        private System.Windows.Forms.Button btnEventEdit;
        private System.Windows.Forms.Label lblEventStartDate;
        private System.Windows.Forms.Label lblEventLocation;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblEventDescription;
        private System.Windows.Forms.TextBox txtEventLocation;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.TextBox txtEventDescription;
        private System.Windows.Forms.DateTimePicker dtpEventStartDate;
        private System.Windows.Forms.DateTimePicker dtpEventEndDate;
        private System.Windows.Forms.Label lblEventEndDate;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnEventAdd;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}