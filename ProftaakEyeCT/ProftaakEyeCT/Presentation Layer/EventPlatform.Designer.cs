﻿namespace ProftaakEyeCT.Presentation_Layer
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
            this.groupBox1.Location = new System.Drawing.Point(266, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 367);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
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
            this.lblEventStartDate.Location = new System.Drawing.Point(30, 293);
            this.lblEventStartDate.Name = "lblEventStartDate";
            this.lblEventStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblEventStartDate.TabIndex = 32;
            this.lblEventStartDate.Text = "Start Date:";
            // 
            // lblEventLocation
            // 
            this.lblEventLocation.AutoSize = true;
            this.lblEventLocation.Location = new System.Drawing.Point(30, 250);
            this.lblEventLocation.Name = "lblEventLocation";
            this.lblEventLocation.Size = new System.Drawing.Size(51, 13);
            this.lblEventLocation.TabIndex = 31;
            this.lblEventLocation.Text = "Location:";
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Location = new System.Drawing.Point(30, 207);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(38, 13);
            this.lblEventName.TabIndex = 30;
            this.lblEventName.Text = "Name:";
            // 
            // lblEventDescription
            // 
            this.lblEventDescription.AutoSize = true;
            this.lblEventDescription.Location = new System.Drawing.Point(30, 144);
            this.lblEventDescription.Name = "lblEventDescription";
            this.lblEventDescription.Size = new System.Drawing.Size(63, 13);
            this.lblEventDescription.TabIndex = 29;
            this.lblEventDescription.Text = "Description:";
            // 
            // txtEventLocation
            // 
            this.txtEventLocation.Location = new System.Drawing.Point(30, 266);
            this.txtEventLocation.Name = "txtEventLocation";
            this.txtEventLocation.Size = new System.Drawing.Size(120, 20);
            this.txtEventLocation.TabIndex = 26;
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(30, 222);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(120, 20);
            this.txtEventName.TabIndex = 25;
            // 
            // txtEventDescription
            // 
            this.txtEventDescription.Location = new System.Drawing.Point(30, 162);
            this.txtEventDescription.Multiline = true;
            this.txtEventDescription.Name = "txtEventDescription";
            this.txtEventDescription.Size = new System.Drawing.Size(169, 42);
            this.txtEventDescription.TabIndex = 24;
            // 
            // dtpEventStartDate
            // 
            this.dtpEventStartDate.Checked = false;
            this.dtpEventStartDate.Location = new System.Drawing.Point(30, 309);
            this.dtpEventStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEventStartDate.Name = "dtpEventStartDate";
            this.dtpEventStartDate.Size = new System.Drawing.Size(169, 20);
            this.dtpEventStartDate.TabIndex = 17;
            // 
            // dtpEventEndDate
            // 
            this.dtpEventEndDate.Checked = false;
            this.dtpEventEndDate.Location = new System.Drawing.Point(30, 355);
            this.dtpEventEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEventEndDate.Name = "dtpEventEndDate";
            this.dtpEventEndDate.Size = new System.Drawing.Size(169, 20);
            this.dtpEventEndDate.TabIndex = 36;
            // 
            // lblEventEndDate
            // 
            this.lblEventEndDate.AutoSize = true;
            this.lblEventEndDate.Location = new System.Drawing.Point(30, 339);
            this.lblEventEndDate.Name = "lblEventEndDate";
            this.lblEventEndDate.Size = new System.Drawing.Size(55, 13);
            this.lblEventEndDate.TabIndex = 37;
            this.lblEventEndDate.Text = "End Date:";
            // 
            // btnEventAdd
            // 
            this.btnEventAdd.Location = new System.Drawing.Point(30, 393);
            this.btnEventAdd.Name = "btnEventAdd";
            this.btnEventAdd.Size = new System.Drawing.Size(169, 23);
            this.btnEventAdd.TabIndex = 39;
            this.btnEventAdd.Text = "Add event";
            this.btnEventAdd.UseVisualStyleBackColor = true;
            this.btnEventAdd.Click += new System.EventHandler(this.btnEventAdd_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProftaakEyeCT.Properties.Resources.events;
            this.pictureBox2.Location = new System.Drawing.Point(212, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(293, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProftaakEyeCT.Properties.Resources.bar;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 498);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(704, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::ProftaakEyeCT.Properties.Resources.bar;
            this.pictureBox6.Location = new System.Drawing.Point(-2, 81);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(704, 19);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 40;
            this.pictureBox6.TabStop = false;
            // 
            // EventPlatform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(701, 493);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.btnEventAdd);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button btnEventAdd;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}