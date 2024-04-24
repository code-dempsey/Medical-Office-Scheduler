namespace OfficeScheduler
{
    partial class formModifyPatient
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
            this.dgvPatient = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.fldName = new System.Windows.Forms.TextBox();
            this.gbPatientInformation = new System.Windows.Forms.GroupBox();
            this.fldAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.fldAllergies = new System.Windows.Forms.TextBox();
            this.lblAllergies = new System.Windows.Forms.Label();
            this.fldInsuranceGroup = new System.Windows.Forms.TextBox();
            this.fldSSN = new System.Windows.Forms.TextBox();
            this.fldInsuranceID = new System.Windows.Forms.TextBox();
            this.lblSSN = new System.Windows.Forms.Label();
            this.lblInsuranceGroup = new System.Windows.Forms.Label();
            this.lblInsuranceID = new System.Windows.Forms.Label();
            this.fldEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fldPostal = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.fldPhone = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.fldState = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.fldCity = new System.Windows.Forms.TextBox();
            this.fldAddress2 = new System.Windows.Forms.TextBox();
            this.fldAddress = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).BeginInit();
            this.gbPatientInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(395, 528);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvPatient
            // 
            this.dgvPatient.AllowUserToAddRows = false;
            this.dgvPatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatient.Location = new System.Drawing.Point(28, 33);
            this.dgvPatient.MultiSelect = false;
            this.dgvPatient.Name = "dgvPatient";
            this.dgvPatient.ReadOnly = true;
            this.dgvPatient.RowHeadersVisible = false;
            this.dgvPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatient.Size = new System.Drawing.Size(446, 196);
            this.dgvPatient.TabIndex = 1;
            this.dgvPatient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatient_CellClick);
            this.dgvPatient.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPatient_DataBindingComplete);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(262, 243);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(348, 243);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // fldName
            // 
            this.fldName.Location = new System.Drawing.Point(80, 19);
            this.fldName.Name = "fldName";
            this.fldName.Size = new System.Drawing.Size(179, 20);
            this.fldName.TabIndex = 4;
            // 
            // gbPatientInformation
            // 
            this.gbPatientInformation.Controls.Add(this.fldAge);
            this.gbPatientInformation.Controls.Add(this.lblAge);
            this.gbPatientInformation.Controls.Add(this.fldAllergies);
            this.gbPatientInformation.Controls.Add(this.lblAllergies);
            this.gbPatientInformation.Controls.Add(this.fldInsuranceGroup);
            this.gbPatientInformation.Controls.Add(this.fldSSN);
            this.gbPatientInformation.Controls.Add(this.fldInsuranceID);
            this.gbPatientInformation.Controls.Add(this.lblSSN);
            this.gbPatientInformation.Controls.Add(this.lblInsuranceGroup);
            this.gbPatientInformation.Controls.Add(this.lblInsuranceID);
            this.gbPatientInformation.Controls.Add(this.fldEmail);
            this.gbPatientInformation.Controls.Add(this.lblEmail);
            this.gbPatientInformation.Controls.Add(this.label1);
            this.gbPatientInformation.Controls.Add(this.fldPostal);
            this.gbPatientInformation.Controls.Add(this.lblPhone);
            this.gbPatientInformation.Controls.Add(this.btnDelete);
            this.gbPatientInformation.Controls.Add(this.fldPhone);
            this.gbPatientInformation.Controls.Add(this.btnSave);
            this.gbPatientInformation.Controls.Add(this.lblState);
            this.gbPatientInformation.Controls.Add(this.fldState);
            this.gbPatientInformation.Controls.Add(this.lblCity);
            this.gbPatientInformation.Controls.Add(this.lblAddress2);
            this.gbPatientInformation.Controls.Add(this.lblAddress);
            this.gbPatientInformation.Controls.Add(this.lblName);
            this.gbPatientInformation.Controls.Add(this.fldName);
            this.gbPatientInformation.Controls.Add(this.fldCity);
            this.gbPatientInformation.Controls.Add(this.fldAddress2);
            this.gbPatientInformation.Controls.Add(this.fldAddress);
            this.gbPatientInformation.Location = new System.Drawing.Point(28, 235);
            this.gbPatientInformation.Name = "gbPatientInformation";
            this.gbPatientInformation.Size = new System.Drawing.Size(446, 280);
            this.gbPatientInformation.TabIndex = 5;
            this.gbPatientInformation.TabStop = false;
            this.gbPatientInformation.Text = "Patient Information";
            // 
            // fldAge
            // 
            this.fldAge.Location = new System.Drawing.Point(323, 19);
            this.fldAge.Name = "fldAge";
            this.fldAge.Size = new System.Drawing.Size(49, 20);
            this.fldAge.TabIndex = 37;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(291, 22);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 36;
            this.lblAge.Text = "Age";
            // 
            // fldAllergies
            // 
            this.fldAllergies.Location = new System.Drawing.Point(65, 195);
            this.fldAllergies.Multiline = true;
            this.fldAllergies.Name = "fldAllergies";
            this.fldAllergies.Size = new System.Drawing.Size(152, 71);
            this.fldAllergies.TabIndex = 35;
            // 
            // lblAllergies
            // 
            this.lblAllergies.AutoSize = true;
            this.lblAllergies.Location = new System.Drawing.Point(13, 210);
            this.lblAllergies.Name = "lblAllergies";
            this.lblAllergies.Size = new System.Drawing.Size(46, 13);
            this.lblAllergies.TabIndex = 34;
            this.lblAllergies.Text = "Allergies";
            // 
            // fldInsuranceGroup
            // 
            this.fldInsuranceGroup.Location = new System.Drawing.Point(323, 156);
            this.fldInsuranceGroup.Name = "fldInsuranceGroup";
            this.fldInsuranceGroup.Size = new System.Drawing.Size(100, 20);
            this.fldInsuranceGroup.TabIndex = 33;
            // 
            // fldSSN
            // 
            this.fldSSN.Location = new System.Drawing.Point(323, 182);
            this.fldSSN.Name = "fldSSN";
            this.fldSSN.Size = new System.Drawing.Size(100, 20);
            this.fldSSN.TabIndex = 32;
            // 
            // fldInsuranceID
            // 
            this.fldInsuranceID.Location = new System.Drawing.Point(323, 130);
            this.fldInsuranceID.Name = "fldInsuranceID";
            this.fldInsuranceID.Size = new System.Drawing.Size(100, 20);
            this.fldInsuranceID.TabIndex = 31;
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Location = new System.Drawing.Point(288, 185);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(29, 13);
            this.lblSSN.TabIndex = 30;
            this.lblSSN.Text = "SSN";
            // 
            // lblInsuranceGroup
            // 
            this.lblInsuranceGroup.AutoSize = true;
            this.lblInsuranceGroup.Location = new System.Drawing.Point(231, 159);
            this.lblInsuranceGroup.Name = "lblInsuranceGroup";
            this.lblInsuranceGroup.Size = new System.Drawing.Size(86, 13);
            this.lblInsuranceGroup.TabIndex = 29;
            this.lblInsuranceGroup.Text = "Insurance Group";
            // 
            // lblInsuranceID
            // 
            this.lblInsuranceID.AutoSize = true;
            this.lblInsuranceID.Location = new System.Drawing.Point(249, 134);
            this.lblInsuranceID.Name = "lblInsuranceID";
            this.lblInsuranceID.Size = new System.Drawing.Size(68, 13);
            this.lblInsuranceID.TabIndex = 28;
            this.lblInsuranceID.Text = "Insurance ID";
            // 
            // fldEmail
            // 
            this.fldEmail.Location = new System.Drawing.Point(323, 81);
            this.fldEmail.Name = "fldEmail";
            this.fldEmail.Size = new System.Drawing.Size(100, 20);
            this.fldEmail.TabIndex = 20;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(285, 84);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Postal Code";
            // 
            // fldPostal
            // 
            this.fldPostal.Location = new System.Drawing.Point(80, 160);
            this.fldPostal.Name = "fldPostal";
            this.fldPostal.Size = new System.Drawing.Size(100, 20);
            this.fldPostal.TabIndex = 17;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(279, 59);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 16;
            this.lblPhone.Text = "Phone";
            // 
            // fldPhone
            // 
            this.fldPhone.Location = new System.Drawing.Point(323, 56);
            this.fldPhone.Name = "fldPhone";
            this.fldPhone.Size = new System.Drawing.Size(100, 20);
            this.fldPhone.TabIndex = 15;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(42, 137);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 14;
            this.lblState.Text = "State";
            // 
            // fldState
            // 
            this.fldState.Location = new System.Drawing.Point(80, 134);
            this.fldState.Name = "fldState";
            this.fldState.Size = new System.Drawing.Size(100, 20);
            this.fldState.TabIndex = 13;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(50, 111);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 12;
            this.lblCity.Text = "City";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(20, 85);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(54, 13);
            this.lblAddress2.TabIndex = 11;
            this.lblAddress2.Text = "Address 2";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(29, 59);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Address";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(39, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name";
            // 
            // fldCity
            // 
            this.fldCity.Location = new System.Drawing.Point(80, 108);
            this.fldCity.Name = "fldCity";
            this.fldCity.Size = new System.Drawing.Size(100, 20);
            this.fldCity.TabIndex = 7;
            // 
            // fldAddress2
            // 
            this.fldAddress2.Location = new System.Drawing.Point(80, 82);
            this.fldAddress2.Name = "fldAddress2";
            this.fldAddress2.Size = new System.Drawing.Size(179, 20);
            this.fldAddress2.TabIndex = 1;
            // 
            // fldAddress
            // 
            this.fldAddress.Location = new System.Drawing.Point(80, 56);
            this.fldAddress.Name = "fldAddress";
            this.fldAddress.Size = new System.Drawing.Size(179, 20);
            this.fldAddress.TabIndex = 0;
            // 
            // formModifyPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 570);
            this.Controls.Add(this.gbPatientInformation);
            this.Controls.Add(this.dgvPatient);
            this.Controls.Add(this.btnExit);
            this.Name = "formModifyPatient";
            this.Text = "Modify/Delete Customer";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).EndInit();
            this.gbPatientInformation.ResumeLayout(false);
            this.gbPatientInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvPatient;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox fldName;
        private System.Windows.Forms.GroupBox gbPatientInformation;
        private System.Windows.Forms.TextBox fldAddress2;
        private System.Windows.Forms.TextBox fldAddress;
        private System.Windows.Forms.TextBox fldState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox fldCity;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox fldPhone;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox fldPostal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fldEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox fldInsuranceGroup;
        private System.Windows.Forms.TextBox fldSSN;
        private System.Windows.Forms.TextBox fldInsuranceID;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.Label lblInsuranceGroup;
        private System.Windows.Forms.Label lblInsuranceID;
        private System.Windows.Forms.TextBox fldAllergies;
        private System.Windows.Forms.Label lblAllergies;
        private System.Windows.Forms.TextBox fldAge;
        private System.Windows.Forms.Label lblAge;
    }
}