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
            this.groupBox1.Location = new System.Drawing.Point(342, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(561, 452);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "gbAllEvents";
            // 
            // btnEventRemove
            // 
            this.btnEventRemove.Enabled = false;
            this.btnEventRemove.Location = new System.Drawing.Point(393, 416);
            this.btnEventRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnEventRemove.Name = "btnEventRemove";
            this.btnEventRemove.Size = new System.Drawing.Size(160, 28);
            this.btnEventRemove.TabIndex = 16;
            this.btnEventRemove.Text = "Remove";
            this.btnEventRemove.UseVisualStyleBackColor = true;
            this.btnEventRemove.Click += new System.EventHandler(this.btnEventRemove_Click);
            // 
            // lbAllEvents
            // 
            this.lbAllEvents.FormattingEnabled = true;
            this.lbAllEvents.ItemHeight = 16;
            this.lbAllEvents.Location = new System.Drawing.Point(8, 22);
            this.lbAllEvents.Margin = new System.Windows.Forms.Padding(4);
            this.lbAllEvents.Name = "lbAllEvents";
            this.lbAllEvents.Size = new System.Drawing.Size(545, 356);
            this.lbAllEvents.TabIndex = 13;
            this.lbAllEvents.SelectedIndexChanged += new System.EventHandler(this.lbAllEvents_SelectedIndexChanged);
            // 
            // btnEventUpdate
            // 
            this.btnEventUpdate.Enabled = false;
            this.btnEventUpdate.Location = new System.Drawing.Point(393, 387);
            this.btnEventUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnEventUpdate.Name = "btnEventUpdate";
            this.btnEventUpdate.Size = new System.Drawing.Size(160, 28);
            this.btnEventUpdate.TabIndex = 15;
            this.btnEventUpdate.Text = "Update";
            this.btnEventUpdate.UseVisualStyleBackColor = true;
            this.btnEventUpdate.Click += new System.EventHandler(this.btnEventUpdate_Click);
            // 
            // btnEventEdit
            // 
            this.btnEventEdit.Enabled = false;
            this.btnEventEdit.Location = new System.Drawing.Point(8, 401);
            this.btnEventEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEventEdit.Name = "btnEventEdit";
            this.btnEventEdit.Size = new System.Drawing.Size(164, 28);
            this.btnEventEdit.TabIndex = 14;
            this.btnEventEdit.Text = "Edit";
            this.btnEventEdit.UseVisualStyleBackColor = true;
            this.btnEventEdit.Click += new System.EventHandler(this.btnEventEdit_Click);
            // 
            // lblEventStartDate
            // 
            this.lblEventStartDate.AutoSize = true;
            this.lblEventStartDate.Location = new System.Drawing.Point(28, 220);
            this.lblEventStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventStartDate.Name = "lblEventStartDate";
            this.lblEventStartDate.Size = new System.Drawing.Size(76, 17);
            this.lblEventStartDate.TabIndex = 32;
            this.lblEventStartDate.Text = "Start Date:";
            // 
            // lblEventLocation
            // 
            this.lblEventLocation.AutoSize = true;
            this.lblEventLocation.Location = new System.Drawing.Point(28, 166);
            this.lblEventLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventLocation.Name = "lblEventLocation";
            this.lblEventLocation.Size = new System.Drawing.Size(66, 17);
            this.lblEventLocation.TabIndex = 31;
            this.lblEventLocation.Text = "Location:";
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Location = new System.Drawing.Point(28, 114);
            this.lblEventName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(49, 17);
            this.lblEventName.TabIndex = 30;
            this.lblEventName.Text = "Name:";
            // 
            // lblEventDescription
            // 
            this.lblEventDescription.AutoSize = true;
            this.lblEventDescription.Location = new System.Drawing.Point(28, 36);
            this.lblEventDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventDescription.Name = "lblEventDescription";
            this.lblEventDescription.Size = new System.Drawing.Size(83, 17);
            this.lblEventDescription.TabIndex = 29;
            this.lblEventDescription.Text = "Description:";
            // 
            // txtEventLocation
            // 
            this.txtEventLocation.Location = new System.Drawing.Point(28, 187);
            this.txtEventLocation.Margin = new System.Windows.Forms.Padding(4);
            this.txtEventLocation.Name = "txtEventLocation";
            this.txtEventLocation.Size = new System.Drawing.Size(159, 22);
            this.txtEventLocation.TabIndex = 26;
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(28, 132);
            this.txtEventName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(159, 22);
            this.txtEventName.TabIndex = 25;
            // 
            // txtEventDescription
            // 
            this.txtEventDescription.Location = new System.Drawing.Point(28, 59);
            this.txtEventDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtEventDescription.Multiline = true;
            this.txtEventDescription.Name = "txtEventDescription";
            this.txtEventDescription.Size = new System.Drawing.Size(224, 51);
            this.txtEventDescription.TabIndex = 24;
            // 
            // dtpEventStartDate
            // 
            this.dtpEventStartDate.Checked = false;
            this.dtpEventStartDate.Location = new System.Drawing.Point(28, 240);
            this.dtpEventStartDate.Name = "dtpEventStartDate";
            this.dtpEventStartDate.Size = new System.Drawing.Size(224, 22);
            this.dtpEventStartDate.TabIndex = 17;
            // 
            // dtpEventEndDate
            // 
            this.dtpEventEndDate.Checked = false;
            this.dtpEventEndDate.Location = new System.Drawing.Point(28, 296);
            this.dtpEventEndDate.Name = "dtpEventEndDate";
            this.dtpEventEndDate.Size = new System.Drawing.Size(224, 22);
            this.dtpEventEndDate.TabIndex = 36;
            // 
            // lblEventEndDate
            // 
            this.lblEventEndDate.AutoSize = true;
            this.lblEventEndDate.Location = new System.Drawing.Point(28, 276);
            this.lblEventEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventEndDate.Name = "lblEventEndDate";
            this.lblEventEndDate.Size = new System.Drawing.Size(71, 17);
            this.lblEventEndDate.TabIndex = 37;
            this.lblEventEndDate.Text = "End Date:";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(52, 403);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 38;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // EventPlatform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 491);
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
            this.Name = "EventPlatform";
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