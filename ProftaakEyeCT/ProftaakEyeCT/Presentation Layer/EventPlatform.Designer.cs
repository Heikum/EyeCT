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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEventRemove);
            this.groupBox1.Controls.Add(this.lbAllEvents);
            this.groupBox1.Controls.Add(this.btnEventUpdate);
            this.groupBox1.Controls.Add(this.btnEventEdit);
            this.groupBox1.Location = new System.Drawing.Point(256, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 367);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "gbAllEvents";
            // 
            // btnEventRemove
            // 
            this.btnEventRemove.Enabled = false;
            this.btnEventRemove.Location = new System.Drawing.Point(295, 338);
            this.btnEventRemove.Name = "btnEventRemove";
            this.btnEventRemove.Size = new System.Drawing.Size(120, 23);
            this.btnEventRemove.TabIndex = 16;
            this.btnEventRemove.Text = "Remove";
            this.btnEventRemove.UseVisualStyleBackColor = true;
            this.btnEventRemove.Click += new System.EventHandler(this.btnEventRemove_Click);
            // 
            // lbAllEvents
            // 
            this.lbAllEvents.FormattingEnabled = true;
            this.lbAllEvents.Location = new System.Drawing.Point(6, 18);
            this.lbAllEvents.Name = "lbAllEvents";
            this.lbAllEvents.Size = new System.Drawing.Size(410, 290);
            this.lbAllEvents.TabIndex = 13;
            this.lbAllEvents.SelectedIndexChanged += new System.EventHandler(this.lbAllEvents_SelectedIndexChanged);
            // 
            // btnEventUpdate
            // 
            this.btnEventUpdate.Enabled = false;
            this.btnEventUpdate.Location = new System.Drawing.Point(295, 314);
            this.btnEventUpdate.Name = "btnEventUpdate";
            this.btnEventUpdate.Size = new System.Drawing.Size(120, 23);
            this.btnEventUpdate.TabIndex = 15;
            this.btnEventUpdate.Text = "Update";
            this.btnEventUpdate.UseVisualStyleBackColor = true;
            this.btnEventUpdate.Click += new System.EventHandler(this.btnEventUpdate_Click);
            // 
            // btnEventEdit
            // 
            this.btnEventEdit.Enabled = false;
            this.btnEventEdit.Location = new System.Drawing.Point(6, 326);
            this.btnEventEdit.Name = "btnEventEdit";
            this.btnEventEdit.Size = new System.Drawing.Size(123, 23);
            this.btnEventEdit.TabIndex = 14;
            this.btnEventEdit.Text = "Edit";
            this.btnEventEdit.UseVisualStyleBackColor = true;
            this.btnEventEdit.Click += new System.EventHandler(this.btnEventEdit_Click);
            // 
            // lblEventStartDate
            // 
            this.lblEventStartDate.AutoSize = true;
            this.lblEventStartDate.Location = new System.Drawing.Point(21, 179);
            this.lblEventStartDate.Name = "lblEventStartDate";
            this.lblEventStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblEventStartDate.TabIndex = 32;
            this.lblEventStartDate.Text = "Start Date:";
            // 
            // lblEventLocation
            // 
            this.lblEventLocation.AutoSize = true;
            this.lblEventLocation.Location = new System.Drawing.Point(21, 135);
            this.lblEventLocation.Name = "lblEventLocation";
            this.lblEventLocation.Size = new System.Drawing.Size(51, 13);
            this.lblEventLocation.TabIndex = 31;
            this.lblEventLocation.Text = "Location:";
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Location = new System.Drawing.Point(21, 93);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(38, 13);
            this.lblEventName.TabIndex = 30;
            this.lblEventName.Text = "Name:";
            // 
            // lblEventDescription
            // 
            this.lblEventDescription.AutoSize = true;
            this.lblEventDescription.Location = new System.Drawing.Point(21, 29);
            this.lblEventDescription.Name = "lblEventDescription";
            this.lblEventDescription.Size = new System.Drawing.Size(63, 13);
            this.lblEventDescription.TabIndex = 29;
            this.lblEventDescription.Text = "Description:";
            // 
            // txtEventLocation
            // 
            this.txtEventLocation.Location = new System.Drawing.Point(21, 152);
            this.txtEventLocation.Name = "txtEventLocation";
            this.txtEventLocation.Size = new System.Drawing.Size(120, 20);
            this.txtEventLocation.TabIndex = 26;
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(21, 107);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(120, 20);
            this.txtEventName.TabIndex = 25;
            // 
            // txtEventDescription
            // 
            this.txtEventDescription.Location = new System.Drawing.Point(21, 48);
            this.txtEventDescription.Multiline = true;
            this.txtEventDescription.Name = "txtEventDescription";
            this.txtEventDescription.Size = new System.Drawing.Size(169, 42);
            this.txtEventDescription.TabIndex = 24;
            // 
            // dtpEventStartDate
            // 
            this.dtpEventStartDate.Checked = false;
            this.dtpEventStartDate.Location = new System.Drawing.Point(21, 195);
            this.dtpEventStartDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpEventStartDate.Name = "dtpEventStartDate";
            this.dtpEventStartDate.Size = new System.Drawing.Size(169, 20);
            this.dtpEventStartDate.TabIndex = 17;
            // 
            // dtpEventEndDate
            // 
            this.dtpEventEndDate.Checked = false;
            this.dtpEventEndDate.Location = new System.Drawing.Point(21, 240);
            this.dtpEventEndDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpEventEndDate.Name = "dtpEventEndDate";
            this.dtpEventEndDate.Size = new System.Drawing.Size(169, 20);
            this.dtpEventEndDate.TabIndex = 36;
            // 
            // lblEventEndDate
            // 
            this.lblEventEndDate.AutoSize = true;
            this.lblEventEndDate.Location = new System.Drawing.Point(21, 224);
            this.lblEventEndDate.Name = "lblEventEndDate";
            this.lblEventEndDate.Size = new System.Drawing.Size(55, 13);
            this.lblEventEndDate.TabIndex = 37;
            this.lblEventEndDate.Text = "End Date:";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(39, 327);
            this.btnTest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(56, 19);
            this.btnTest.TabIndex = 38;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // EventPlatform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 399);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EventPlatform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventPlatform";
            this.groupBox1.ResumeLayout(false);
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
    }
}