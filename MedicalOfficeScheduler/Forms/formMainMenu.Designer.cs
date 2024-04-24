using OfficeScheduler.Database;

namespace OfficeScheduler
{
    partial class formMainMenu
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
            this.dgvCalendar = new System.Windows.Forms.DataGridView();
            this.grpboxAppointmentCalendar = new System.Windows.Forms.GroupBox();
            this.btnDeleteAppointment = new System.Windows.Forms.Button();
            this.btnModifyAppointment = new System.Windows.Forms.Button();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioPatient = new System.Windows.Forms.RadioButton();
            this.radioPhys = new System.Windows.Forms.RadioButton();
            this.fldSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddNewPatient = new System.Windows.Forms.Button();
            this.btnModifyDeletePatient = new System.Windows.Forms.Button();
            this.grpboxCustomerControl = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.mCalendar = new System.Windows.Forms.MonthCalendar();
            this.btnApply = new System.Windows.Forms.Button();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.radioDay = new System.Windows.Forms.RadioButton();
            this.radioWeek = new System.Windows.Forms.RadioButton();
            this.radioMonth = new System.Windows.Forms.RadioButton();
            this.grpBoxCalendarFilter = new System.Windows.Forms.GroupBox();
            this.btnReportingTool = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnModifyDeletePhysician = new System.Windows.Forms.Button();
            this.btnAddNewPhysician = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalendar)).BeginInit();
            this.grpboxAppointmentCalendar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpboxCustomerControl.SuspendLayout();
            this.grpBoxCalendarFilter.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCalendar
            // 
            this.dgvCalendar.AllowUserToAddRows = false;
            this.dgvCalendar.AllowUserToDeleteRows = false;
            this.dgvCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalendar.Location = new System.Drawing.Point(24, 29);
            this.dgvCalendar.MultiSelect = false;
            this.dgvCalendar.Name = "dgvCalendar";
            this.dgvCalendar.ReadOnly = true;
            this.dgvCalendar.RowHeadersVisible = false;
            this.dgvCalendar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCalendar.Size = new System.Drawing.Size(659, 390);
            this.dgvCalendar.TabIndex = 1;
            this.dgvCalendar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCalendar_CellClick);
            this.dgvCalendar.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCalendar_DataBindingComplete);
            // 
            // grpboxAppointmentCalendar
            // 
            this.grpboxAppointmentCalendar.Controls.Add(this.btnDeleteAppointment);
            this.grpboxAppointmentCalendar.Controls.Add(this.btnModifyAppointment);
            this.grpboxAppointmentCalendar.Controls.Add(this.btnAddAppointment);
            this.grpboxAppointmentCalendar.Controls.Add(this.dgvCalendar);
            this.grpboxAppointmentCalendar.Controls.Add(this.groupBox1);
            this.grpboxAppointmentCalendar.Location = new System.Drawing.Point(286, 11);
            this.grpboxAppointmentCalendar.Name = "grpboxAppointmentCalendar";
            this.grpboxAppointmentCalendar.Size = new System.Drawing.Size(709, 481);
            this.grpboxAppointmentCalendar.TabIndex = 2;
            this.grpboxAppointmentCalendar.TabStop = false;
            this.grpboxAppointmentCalendar.Text = "Appointment Calendar";
            // 
            // btnDeleteAppointment
            // 
            this.btnDeleteAppointment.Location = new System.Drawing.Point(197, 440);
            this.btnDeleteAppointment.Name = "btnDeleteAppointment";
            this.btnDeleteAppointment.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAppointment.TabIndex = 4;
            this.btnDeleteAppointment.Text = "Delete";
            this.btnDeleteAppointment.UseVisualStyleBackColor = true;
            this.btnDeleteAppointment.Click += new System.EventHandler(this.btnDeleteAppointment_Click);
            // 
            // btnModifyAppointment
            // 
            this.btnModifyAppointment.Location = new System.Drawing.Point(116, 440);
            this.btnModifyAppointment.Name = "btnModifyAppointment";
            this.btnModifyAppointment.Size = new System.Drawing.Size(75, 23);
            this.btnModifyAppointment.TabIndex = 3;
            this.btnModifyAppointment.Text = "Modify";
            this.btnModifyAppointment.UseVisualStyleBackColor = true;
            this.btnModifyAppointment.Click += new System.EventHandler(this.btnModifyAppointment_Click);
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Location = new System.Drawing.Point(35, 440);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(75, 23);
            this.btnAddAppointment.TabIndex = 2;
            this.btnAddAppointment.Text = "Add";
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioPatient);
            this.groupBox1.Controls.Add(this.radioPhys);
            this.groupBox1.Controls.Add(this.fldSearch);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(278, 425);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 50);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointment Search";
            // 
            // radioPatient
            // 
            this.radioPatient.AutoSize = true;
            this.radioPatient.Location = new System.Drawing.Point(98, 19);
            this.radioPatient.Name = "radioPatient";
            this.radioPatient.Size = new System.Drawing.Size(58, 17);
            this.radioPatient.TabIndex = 8;
            this.radioPatient.TabStop = true;
            this.radioPatient.Text = "Patient";
            this.radioPatient.UseVisualStyleBackColor = true;
            // 
            // radioPhys
            // 
            this.radioPhys.AutoSize = true;
            this.radioPhys.Checked = true;
            this.radioPhys.Location = new System.Drawing.Point(7, 19);
            this.radioPhys.Name = "radioPhys";
            this.radioPhys.Size = new System.Drawing.Size(70, 17);
            this.radioPhys.TabIndex = 7;
            this.radioPhys.TabStop = true;
            this.radioPhys.Text = "Physician";
            this.radioPhys.UseVisualStyleBackColor = true;
            // 
            // fldSearch
            // 
            this.fldSearch.Location = new System.Drawing.Point(184, 17);
            this.fldSearch.Name = "fldSearch";
            this.fldSearch.Size = new System.Drawing.Size(122, 20);
            this.fldSearch.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(312, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddNewPatient
            // 
            this.btnAddNewPatient.Location = new System.Drawing.Point(6, 30);
            this.btnAddNewPatient.Name = "btnAddNewPatient";
            this.btnAddNewPatient.Size = new System.Drawing.Size(202, 23);
            this.btnAddNewPatient.TabIndex = 3;
            this.btnAddNewPatient.Text = "Add New Patient";
            this.btnAddNewPatient.UseVisualStyleBackColor = true;
            this.btnAddNewPatient.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // btnModifyDeletePatient
            // 
            this.btnModifyDeletePatient.Location = new System.Drawing.Point(6, 60);
            this.btnModifyDeletePatient.Name = "btnModifyDeletePatient";
            this.btnModifyDeletePatient.Size = new System.Drawing.Size(202, 23);
            this.btnModifyDeletePatient.TabIndex = 4;
            this.btnModifyDeletePatient.Text = "Modify/Delete Patient";
            this.btnModifyDeletePatient.UseVisualStyleBackColor = true;
            this.btnModifyDeletePatient.Click += new System.EventHandler(this.btnModifyExistingCustomer_Click);
            // 
            // grpboxCustomerControl
            // 
            this.grpboxCustomerControl.Controls.Add(this.btnModifyDeletePatient);
            this.grpboxCustomerControl.Controls.Add(this.btnAddNewPatient);
            this.grpboxCustomerControl.Location = new System.Drawing.Point(33, 287);
            this.grpboxCustomerControl.Name = "grpboxCustomerControl";
            this.grpboxCustomerControl.Size = new System.Drawing.Size(221, 101);
            this.grpboxCustomerControl.TabIndex = 6;
            this.grpboxCustomerControl.TabStop = false;
            this.grpboxCustomerControl.Text = "Patient Control";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(906, 511);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // mCalendar
            // 
            this.mCalendar.Location = new System.Drawing.Point(27, 105);
            this.mCalendar.Name = "mCalendar";
            this.mCalendar.TabIndex = 8;
            this.mCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mCalendar_DateChanged);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(174, 47);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 9;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // radioAll
            // 
            this.radioAll.AutoSize = true;
            this.radioAll.Checked = true;
            this.radioAll.Location = new System.Drawing.Point(37, 39);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(77, 17);
            this.radioAll.TabIndex = 10;
            this.radioAll.TabStop = true;
            this.radioAll.Text = "All (default)";
            this.radioAll.UseVisualStyleBackColor = true;
            // 
            // radioDay
            // 
            this.radioDay.AutoSize = true;
            this.radioDay.Location = new System.Drawing.Point(121, 39);
            this.radioDay.Name = "radioDay";
            this.radioDay.Size = new System.Drawing.Size(44, 17);
            this.radioDay.TabIndex = 11;
            this.radioDay.TabStop = true;
            this.radioDay.Text = "Day";
            this.radioDay.UseVisualStyleBackColor = true;
            // 
            // radioWeek
            // 
            this.radioWeek.AutoSize = true;
            this.radioWeek.Location = new System.Drawing.Point(37, 63);
            this.radioWeek.Name = "radioWeek";
            this.radioWeek.Size = new System.Drawing.Size(54, 17);
            this.radioWeek.TabIndex = 12;
            this.radioWeek.TabStop = true;
            this.radioWeek.Text = "Week";
            this.radioWeek.UseVisualStyleBackColor = true;
            // 
            // radioMonth
            // 
            this.radioMonth.AutoSize = true;
            this.radioMonth.Location = new System.Drawing.Point(121, 63);
            this.radioMonth.Name = "radioMonth";
            this.radioMonth.Size = new System.Drawing.Size(55, 17);
            this.radioMonth.TabIndex = 13;
            this.radioMonth.TabStop = true;
            this.radioMonth.Text = "Month";
            this.radioMonth.UseVisualStyleBackColor = true;
            // 
            // grpBoxCalendarFilter
            // 
            this.grpBoxCalendarFilter.Controls.Add(this.btnApply);
            this.grpBoxCalendarFilter.Location = new System.Drawing.Point(12, 12);
            this.grpBoxCalendarFilter.Name = "grpBoxCalendarFilter";
            this.grpBoxCalendarFilter.Size = new System.Drawing.Size(267, 269);
            this.grpBoxCalendarFilter.TabIndex = 14;
            this.grpBoxCalendarFilter.TabStop = false;
            this.grpBoxCalendarFilter.Text = "Calendar Filter";
            // 
            // btnReportingTool
            // 
            this.btnReportingTool.Location = new System.Drawing.Point(77, 511);
            this.btnReportingTool.Name = "btnReportingTool";
            this.btnReportingTool.Size = new System.Drawing.Size(115, 23);
            this.btnReportingTool.TabIndex = 15;
            this.btnReportingTool.Text = "Reporting Tool";
            this.btnReportingTool.UseVisualStyleBackColor = true;
            this.btnReportingTool.Click += new System.EventHandler(this.btnReportingTool_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnModifyDeletePhysician);
            this.groupBox2.Controls.Add(this.btnAddNewPhysician);
            this.groupBox2.Location = new System.Drawing.Point(33, 391);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 101);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Physician Control";
            // 
            // btnModifyDeletePhysician
            // 
            this.btnModifyDeletePhysician.Location = new System.Drawing.Point(6, 60);
            this.btnModifyDeletePhysician.Name = "btnModifyDeletePhysician";
            this.btnModifyDeletePhysician.Size = new System.Drawing.Size(202, 23);
            this.btnModifyDeletePhysician.TabIndex = 4;
            this.btnModifyDeletePhysician.Text = "Modify/Delete Physician";
            this.btnModifyDeletePhysician.UseVisualStyleBackColor = true;
            this.btnModifyDeletePhysician.Click += new System.EventHandler(this.btnModifyDeletePhysician_Click);
            // 
            // btnAddNewPhysician
            // 
            this.btnAddNewPhysician.Location = new System.Drawing.Point(6, 30);
            this.btnAddNewPhysician.Name = "btnAddNewPhysician";
            this.btnAddNewPhysician.Size = new System.Drawing.Size(202, 23);
            this.btnAddNewPhysician.TabIndex = 3;
            this.btnAddNewPhysician.Text = "Add New Physician";
            this.btnAddNewPhysician.UseVisualStyleBackColor = true;
            this.btnAddNewPhysician.Click += new System.EventHandler(this.btnAddNewPhysician_Click);
            // 
            // formMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1023, 555);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnReportingTool);
            this.Controls.Add(this.radioMonth);
            this.Controls.Add(this.radioWeek);
            this.Controls.Add(this.radioDay);
            this.Controls.Add(this.radioAll);
            this.Controls.Add(this.mCalendar);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpboxCustomerControl);
            this.Controls.Add(this.grpboxAppointmentCalendar);
            this.Controls.Add(this.grpBoxCalendarFilter);
            this.Name = "formMainMenu";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalendar)).EndInit();
            this.grpboxAppointmentCalendar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpboxCustomerControl.ResumeLayout(false);
            this.grpBoxCalendarFilter.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpboxAppointmentCalendar;
        private System.Windows.Forms.Button btnDeleteAppointment;
        private System.Windows.Forms.Button btnModifyAppointment;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.Button btnAddNewPatient;
        private System.Windows.Forms.Button btnModifyDeletePatient;
        private System.Windows.Forms.GroupBox grpboxCustomerControl;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.DataGridView dgvCalendar;
        private System.Windows.Forms.MonthCalendar mCalendar;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.RadioButton radioAll;
        private System.Windows.Forms.RadioButton radioDay;
        private System.Windows.Forms.RadioButton radioWeek;
        private System.Windows.Forms.RadioButton radioMonth;
        private System.Windows.Forms.GroupBox grpBoxCalendarFilter;
        private System.Windows.Forms.Button btnReportingTool;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox fldSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnModifyDeletePhysician;
        private System.Windows.Forms.Button btnAddNewPhysician;
        private System.Windows.Forms.RadioButton radioPatient;
        private System.Windows.Forms.RadioButton radioPhys;
    }
}