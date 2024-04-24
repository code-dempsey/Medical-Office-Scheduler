
namespace OfficeScheduler.Forms
{
    partial class formReports
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
            this.dtpAppointment = new System.Windows.Forms.DateTimePicker();
            this.btnShowATMReport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbPhysician = new System.Windows.Forms.ComboBox();
            this.cbPhysician1 = new System.Windows.Forms.ComboBox();
            this.btnShowCSReport = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbPatient = new System.Windows.Forms.ComboBox();
            this.btShowACReport = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpAppointment
            // 
            this.dtpAppointment.CustomFormat = "MMMM - yyyy";
            this.dtpAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAppointment.Location = new System.Drawing.Point(174, 39);
            this.dtpAppointment.Name = "dtpAppointment";
            this.dtpAppointment.ShowUpDown = true;
            this.dtpAppointment.Size = new System.Drawing.Size(119, 20);
            this.dtpAppointment.TabIndex = 0;
            // 
            // btnShowATMReport
            // 
            this.btnShowATMReport.Location = new System.Drawing.Point(174, 81);
            this.btnShowATMReport.Name = "btnShowATMReport";
            this.btnShowATMReport.Size = new System.Drawing.Size(98, 23);
            this.btnShowATMReport.TabIndex = 8;
            this.btnShowATMReport.Text = "Show Report";
            this.btnShowATMReport.UseVisualStyleBackColor = true;
            this.btnShowATMReport.Click += new System.EventHandler(this.btnAppByMonth_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpAppointment);
            this.groupBox1.Controls.Add(this.btnShowATMReport);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(33, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 133);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Number of Appointments by Physician/Month";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbPhysician);
            this.groupBox2.Location = new System.Drawing.Point(6, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 55);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Physician";
            // 
            // cbPhysician
            // 
            this.cbPhysician.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhysician.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbPhysician.FormattingEnabled = true;
            this.cbPhysician.Location = new System.Drawing.Point(9, 19);
            this.cbPhysician.Name = "cbPhysician";
            this.cbPhysician.Size = new System.Drawing.Size(121, 21);
            this.cbPhysician.TabIndex = 11;
            // 
            // cbPhysician1
            // 
            this.cbPhysician1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhysician1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbPhysician1.FormattingEnabled = true;
            this.cbPhysician1.Location = new System.Drawing.Point(48, 195);
            this.cbPhysician1.Name = "cbPhysician1";
            this.cbPhysician1.Size = new System.Drawing.Size(121, 21);
            this.cbPhysician1.TabIndex = 10;
            // 
            // btnShowCSReport
            // 
            this.btnShowCSReport.Location = new System.Drawing.Point(207, 192);
            this.btnShowCSReport.Name = "btnShowCSReport";
            this.btnShowCSReport.Size = new System.Drawing.Size(98, 23);
            this.btnShowCSReport.TabIndex = 11;
            this.btnShowCSReport.Text = "Show Report";
            this.btnShowCSReport.UseVisualStyleBackColor = true;
            this.btnShowCSReport.Click += new System.EventHandler(this.btnShowCSReport_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(33, 166);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 74);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Complete Appointment Schedule by Physician";
            // 
            // cbPatient
            // 
            this.cbPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbPatient.FormattingEnabled = true;
            this.cbPatient.Location = new System.Drawing.Point(48, 271);
            this.cbPatient.Name = "cbPatient";
            this.cbPatient.Size = new System.Drawing.Size(121, 21);
            this.cbPatient.TabIndex = 13;
            // 
            // btShowACReport
            // 
            this.btShowACReport.Location = new System.Drawing.Point(207, 268);
            this.btShowACReport.Name = "btShowACReport";
            this.btShowACReport.Size = new System.Drawing.Size(98, 23);
            this.btShowACReport.TabIndex = 14;
            this.btShowACReport.Text = "Show Report";
            this.btShowACReport.UseVisualStyleBackColor = true;
            this.btShowACReport.Click += new System.EventHandler(this.btShowACReport_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(33, 246);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(307, 66);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Appointments by Patient";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(265, 327);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // formReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 368);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btShowACReport);
            this.Controls.Add(this.cbPatient);
            this.Controls.Add(this.btnShowCSReport);
            this.Controls.Add(this.cbPhysician1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Name = "formReports";
            this.Text = "Reports";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpAppointment;
        private System.Windows.Forms.Button btnShowATMReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbPhysician;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbPhysician1;
        private System.Windows.Forms.Button btnShowCSReport;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbPatient;
        private System.Windows.Forms.Button btShowACReport;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnExit;
    }
}