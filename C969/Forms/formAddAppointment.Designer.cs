namespace OfficeScheduler
{
    partial class formAddAppointment
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
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.fldPatient = new System.Windows.Forms.TextBox();
            this.dgvPatient = new System.Windows.Forms.DataGridView();
            this.lblPatient = new System.Windows.Forms.Label();
            this.fldRoom = new System.Windows.Forms.TextBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.fldVisitReason = new System.Windows.Forms.TextBox();
            this.lblVisitReason = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblEnd = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbPhysician = new System.Windows.Forms.ComboBox();
            this.lblPhysicianSpec = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(487, 288);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "MM/dd/yyyy   HH:mm:ss";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(392, 204);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(148, 20);
            this.dtpStart.TabIndex = 1;
            this.dtpStart.Value = new System.DateTime(2023, 11, 13, 9, 0, 0, 0);
            // 
            // fldPatient
            // 
            this.fldPatient.Location = new System.Drawing.Point(112, 199);
            this.fldPatient.Name = "fldPatient";
            this.fldPatient.ReadOnly = true;
            this.fldPatient.Size = new System.Drawing.Size(100, 20);
            this.fldPatient.TabIndex = 2;
            this.fldPatient.Text = "Select from above";
            // 
            // dgvPatient
            // 
            this.dgvPatient.AllowUserToAddRows = false;
            this.dgvPatient.AllowUserToDeleteRows = false;
            this.dgvPatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatient.Location = new System.Drawing.Point(31, 31);
            this.dgvPatient.MultiSelect = false;
            this.dgvPatient.Name = "dgvPatient";
            this.dgvPatient.ReadOnly = true;
            this.dgvPatient.RowHeadersVisible = false;
            this.dgvPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatient.Size = new System.Drawing.Size(531, 150);
            this.dgvPatient.TabIndex = 3;
            this.dgvPatient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellClick);
            this.dgvPatient.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPatient_DataBindingComplete);
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(52, 203);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(54, 13);
            this.lblPatient.TabIndex = 4;
            this.lblPatient.Text = "Patient ID";
            // 
            // fldRoom
            // 
            this.fldRoom.Location = new System.Drawing.Point(112, 307);
            this.fldRoom.Name = "fldRoom";
            this.fldRoom.Size = new System.Drawing.Size(66, 20);
            this.fldRoom.TabIndex = 9;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(71, 310);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(35, 13);
            this.lblRoom.TabIndex = 10;
            this.lblRoom.Text = "Room";
            // 
            // fldVisitReason
            // 
            this.fldVisitReason.Location = new System.Drawing.Point(112, 257);
            this.fldVisitReason.Multiline = true;
            this.fldVisitReason.Name = "fldVisitReason";
            this.fldVisitReason.Size = new System.Drawing.Size(238, 44);
            this.fldVisitReason.TabIndex = 15;
            // 
            // lblVisitReason
            // 
            this.lblVisitReason.AutoSize = true;
            this.lblVisitReason.Location = new System.Drawing.Point(40, 260);
            this.lblVisitReason.Name = "lblVisitReason";
            this.lblVisitReason.Size = new System.Drawing.Size(66, 13);
            this.lblVisitReason.TabIndex = 16;
            this.lblVisitReason.Text = "Visit Reason";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(357, 206);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(29, 13);
            this.lblStart.TabIndex = 17;
            this.lblStart.Text = "Start";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "MM/dd/yyyy   HH:mm:ss";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(392, 231);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(148, 20);
            this.dtpEnd.TabIndex = 18;
            this.dtpEnd.Value = new System.DateTime(2023, 11, 13, 9, 30, 0, 0);
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(360, 236);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(26, 13);
            this.lblEnd.TabIndex = 19;
            this.lblEnd.Text = "End";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(402, 288);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbPhysician
            // 
            this.cbPhysician.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhysician.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbPhysician.FormattingEnabled = true;
            this.cbPhysician.Location = new System.Drawing.Point(112, 227);
            this.cbPhysician.Name = "cbPhysician";
            this.cbPhysician.Size = new System.Drawing.Size(156, 21);
            this.cbPhysician.TabIndex = 21;
            // 
            // lblPhysicianSpec
            // 
            this.lblPhysicianSpec.AutoSize = true;
            this.lblPhysicianSpec.Location = new System.Drawing.Point(6, 232);
            this.lblPhysicianSpec.Name = "lblPhysicianSpec";
            this.lblPhysicianSpec.Size = new System.Drawing.Size(100, 13);
            this.lblPhysicianSpec.TabIndex = 22;
            this.lblPhysicianSpec.Text = "Physician/Speicalty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Business hours 9AM - 5PM EST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(540, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "EST";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(540, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "EST";
            // 
            // formAddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 345);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPhysicianSpec);
            this.Controls.Add(this.cbPhysician);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblVisitReason);
            this.Controls.Add(this.fldVisitReason);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.fldRoom);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.dgvPatient);
            this.Controls.Add(this.fldPatient);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.btnExit);
            this.Name = "formAddAppointment";
            this.Text = "Add Appointment";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.TextBox fldPatient;
        private System.Windows.Forms.DataGridView dgvPatient;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.TextBox fldRoom;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.TextBox fldVisitReason;
        private System.Windows.Forms.Label lblVisitReason;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbPhysician;
        private System.Windows.Forms.Label lblPhysicianSpec;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}