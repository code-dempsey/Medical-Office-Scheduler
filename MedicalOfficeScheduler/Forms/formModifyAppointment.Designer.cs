namespace OfficeScheduler
{
    partial class formModifyAppointment
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
            this.btnExit = new System.Windows.Forms.Button();
            this.fldAppointmentID = new System.Windows.Forms.TextBox();
            this.lblAppointmentID = new System.Windows.Forms.Label();
            this.lblPatient = new System.Windows.Forms.Label();
            this.fldVisitReason = new System.Windows.Forms.TextBox();
            this.fldRoom = new System.Windows.Forms.TextBox();
            this.lblPhysicianSpec = new System.Windows.Forms.Label();
            this.lblVisitReason = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbPhysician = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPatient = new System.Windows.Forms.DataGridView();
            this.fldPatient = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(462, 315);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fldAppointmentID
            // 
            this.fldAppointmentID.Location = new System.Drawing.Point(116, 212);
            this.fldAppointmentID.Name = "fldAppointmentID";
            this.fldAppointmentID.ReadOnly = true;
            this.fldAppointmentID.Size = new System.Drawing.Size(100, 20);
            this.fldAppointmentID.TabIndex = 1;
            // 
            // lblAppointmentID
            // 
            this.lblAppointmentID.AutoSize = true;
            this.lblAppointmentID.Location = new System.Drawing.Point(30, 215);
            this.lblAppointmentID.Name = "lblAppointmentID";
            this.lblAppointmentID.Size = new System.Drawing.Size(80, 13);
            this.lblAppointmentID.TabIndex = 2;
            this.lblAppointmentID.Text = "Appointment ID";
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(56, 240);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(54, 13);
            this.lblPatient.TabIndex = 3;
            this.lblPatient.Text = "Patient ID";
            // 
            // fldVisitReason
            // 
            this.fldVisitReason.Location = new System.Drawing.Point(116, 291);
            this.fldVisitReason.Multiline = true;
            this.fldVisitReason.Name = "fldVisitReason";
            this.fldVisitReason.Size = new System.Drawing.Size(204, 47);
            this.fldVisitReason.TabIndex = 6;
            // 
            // fldRoom
            // 
            this.fldRoom.Location = new System.Drawing.Point(116, 344);
            this.fldRoom.Name = "fldRoom";
            this.fldRoom.Size = new System.Drawing.Size(52, 20);
            this.fldRoom.TabIndex = 7;
            // 
            // lblPhysicianSpec
            // 
            this.lblPhysicianSpec.AutoSize = true;
            this.lblPhysicianSpec.Location = new System.Drawing.Point(10, 268);
            this.lblPhysicianSpec.Name = "lblPhysicianSpec";
            this.lblPhysicianSpec.Size = new System.Drawing.Size(100, 13);
            this.lblPhysicianSpec.TabIndex = 12;
            this.lblPhysicianSpec.Text = "Physician/Specialty";
            // 
            // lblVisitReason
            // 
            this.lblVisitReason.AutoSize = true;
            this.lblVisitReason.Location = new System.Drawing.Point(44, 294);
            this.lblVisitReason.Name = "lblVisitReason";
            this.lblVisitReason.Size = new System.Drawing.Size(66, 13);
            this.lblVisitReason.TabIndex = 13;
            this.lblVisitReason.Text = "Visit Reason";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(75, 347);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(35, 13);
            this.lblRoom.TabIndex = 14;
            this.lblRoom.Text = "Room";
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "MM/dd/yyyy   HH:mm:ss";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(382, 215);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(147, 20);
            this.dtpStart.TabIndex = 19;
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "MM/dd/yyyy   HH:mm:ss";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(382, 242);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(147, 20);
            this.dtpEnd.TabIndex = 20;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(347, 221);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(29, 13);
            this.lblStart.TabIndex = 21;
            this.lblStart.Text = "Start";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(350, 247);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(26, 13);
            this.lblEnd.TabIndex = 22;
            this.lblEnd.Text = "End";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(370, 315);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbPhysician
            // 
            this.cbPhysician.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhysician.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbPhysician.FormattingEnabled = true;
            this.cbPhysician.Location = new System.Drawing.Point(116, 264);
            this.cbPhysician.Name = "cbPhysician";
            this.cbPhysician.Size = new System.Drawing.Size(155, 21);
            this.cbPhysician.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Business hours 9AM - 5PM EST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(529, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "EST";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(529, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "EST";
            // 
            // dgvPatient
            // 
            this.dgvPatient.AllowUserToAddRows = false;
            this.dgvPatient.AllowUserToDeleteRows = false;
            this.dgvPatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatient.Location = new System.Drawing.Point(41, 34);
            this.dgvPatient.MultiSelect = false;
            this.dgvPatient.Name = "dgvPatient";
            this.dgvPatient.ReadOnly = true;
            this.dgvPatient.RowHeadersVisible = false;
            this.dgvPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatient.Size = new System.Drawing.Size(525, 150);
            this.dgvPatient.TabIndex = 30;
            this.dgvPatient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatient_CellClick);
            this.dgvPatient.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPatient_DataBindingComplete);
            // 
            // fldPatient
            // 
            this.fldPatient.Location = new System.Drawing.Point(116, 238);
            this.fldPatient.Name = "fldPatient";
            this.fldPatient.ReadOnly = true;
            this.fldPatient.Size = new System.Drawing.Size(100, 20);
            this.fldPatient.TabIndex = 31;
            this.fldPatient.Text = "Select from above";
            // 
            // formModifyAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 382);
            this.Controls.Add(this.fldPatient);
            this.Controls.Add(this.dgvPatient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPhysician);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.lblVisitReason);
            this.Controls.Add(this.lblPhysicianSpec);
            this.Controls.Add(this.fldRoom);
            this.Controls.Add(this.fldVisitReason);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.lblAppointmentID);
            this.Controls.Add(this.fldAppointmentID);
            this.Controls.Add(this.btnExit);
            this.Name = "formModifyAppointment";
            this.Text = "Modify Appointment";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox fldAppointmentID;
        private System.Windows.Forms.Label lblAppointmentID;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.TextBox fldVisitReason;
        private System.Windows.Forms.TextBox fldRoom;
        private System.Windows.Forms.Label lblPhysicianSpec;
        private System.Windows.Forms.Label lblVisitReason;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbPhysician;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPatient;
        private System.Windows.Forms.TextBox fldPatient;
    }
}