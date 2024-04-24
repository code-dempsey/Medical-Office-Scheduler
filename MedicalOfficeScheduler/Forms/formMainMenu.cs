using OfficeScheduler.Database;
using OfficeScheduler.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OfficeScheduler
{
    public partial class formMainMenu : Form
    {
        public formMainMenu()
        {
            InitializeComponent();
            LoadDGVCalendar();         
        }
        public void LoadDGVCalendar()
        {
            dgvCalendar.DataSource = User.PopulateAppointmentDGV();
            dgvCalendar.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCalendar.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCalendar.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCalendar.Columns[3].Visible = false;
            dgvCalendar.Columns[4].Visible = false;
            dgvCalendar.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCalendar.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCalendar.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCalendar.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCalendar.Columns[9].Visible = false;
            dgvCalendar.Columns[10].Visible = false;
            dgvCalendar.Columns[11].Visible = false;
            dgvCalendar.Columns[12].Visible = false;
            dgvCalendar.Columns[13].Visible = false;
            dgvCalendar.Sort(dgvCalendar.Columns["Start"], ListSortDirection.Descending);

        }
        Appointment _appointment = new Appointment();
        int appointmentPatientAge = 0;
        

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            Form addAppointment = new formAddAppointment();
            addAppointment.FormClosed += (o, e1) => { updateAppointmentCalendar(); }; 
            addAppointment.ShowDialog();
            
        }
        private void dgvCalendar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _appointment.AppointmentID = (int)dgvCalendar.CurrentRow.Cells["ID"].Value;
            _appointment.PhysicianID = (int)dgvCalendar.CurrentRow.Cells["physicianid"].Value;
            _appointment.PatientID = (int)dgvCalendar.CurrentRow.Cells["patientid"].Value;
            appointmentPatientAge = (int)dgvCalendar.CurrentRow.Cells["age"].Value;
        }

        private void btnModifyAppointment_Click(object sender, EventArgs e)
        {
            if (dgvCalendar.RowCount < 1)
            {
                MessageBox.Show("No appointments to modify.");
            }
            else if (_appointment.AppointmentID <= 0)
            {
                MessageBox.Show("Please select an appointment.");
            }
            else
            {
                Form modAppointment = new formModifyAppointment(_appointment.AppointmentID, _appointment.PhysicianID, _appointment.PatientID, appointmentPatientAge);
                modAppointment.FormClosed += (o, e1) => { updateAppointmentCalendar(); };
                modAppointment.ShowDialog();
            }

        }

        private void btnDeleteAppointment_Click(object sender, EventArgs e)
        {
            if (dgvCalendar.RowCount < 1)
            {
                MessageBox.Show("No appointments to delete.");
            }
            else if (_appointment.AppointmentID <= 0)
            {
                MessageBox.Show("Please select an appointment.");
            }
            else
            {
                var confirmDeletion = MessageBox.Show("Are you sure you wish to delete this appointment?","Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmDeletion == DialogResult.Yes)
                {
                    User.DeleteAppointment(_appointment.AppointmentID);
                    _appointment.AppointmentID = 0;
                    updateAppointmentCalendar();
                }
            }                      
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            Form addCustomer = new formAddPatient();
            addCustomer.FormClosed += (o, e1) => { updateAppointmentCalendar(); };
            addCustomer.ShowDialog();
        }

        private void btnModifyExistingCustomer_Click(object sender, EventArgs e)
        {
            Form modCustomer = new formModifyPatient();
            modCustomer.FormClosed += (o, e1) => { updateAppointmentCalendar(); };
            modCustomer.ShowDialog();
        }
        private void mCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            updateAppointmentCalendar();
            fldSearch.Clear();
        }

        private void btnReportingTool_Click(object sender, EventArgs e)
        {
            Form reports = new formReports();
            reports.ShowDialog();
        }
        private void updateAppointmentCalendar()
        {

            DateTime selectedDate = mCalendar.SelectionStart;
            int dayOfWeek = (int)(selectedDate.DayOfWeek);

            int dayOfMonth = (int)selectedDate.Day;
            DateTime firstDayOfMonth = selectedDate.AddDays(-(dayOfMonth - 1));
            DateTime firstDayOfNextMonth = firstDayOfMonth.AddMonths(1);

            DateTime previousSunday = selectedDate.AddDays(-dayOfWeek);
            DateTime nextSaturday = selectedDate.AddDays(6 - dayOfWeek);

            if (radioAll.Checked)
            {
                dgvCalendar.DataSource = User.PopulateAppointmentDGV();
            }
            else if (radioDay.Checked)
            {
                dgvCalendar.DataSource = User.PopulateAppointmentDGV(selectedDate.ToString("yyyy-MM-dd HH:mm:ss"), selectedDate.AddDays(1).ToString("yyyy-MM-dd HH:mm:ss"));
            }
            else if (radioWeek.Checked)
            {
                dgvCalendar.DataSource = User.PopulateAppointmentDGV(previousSunday.ToString("yyyy-MM-dd 00:00:00"), nextSaturday.ToString("yyyy-MM-dd 00:00:00"));
            }
            else if (radioMonth.Checked)
            {
                dgvCalendar.DataSource = User.PopulateAppointmentDGV(firstDayOfMonth.ToString("yyyy-MM-dd 00:00:00"), firstDayOfNextMonth.ToString("yyyy-MM-dd 00:00:00"));
            }
            dgvCalendar.Refresh();
        }
        private void AppointmentSearch(bool isPhys)
        {
            BindingSource _bs = new BindingSource();
            _bs.DataSource = dgvCalendar.DataSource;
            if (isPhys)
            {
                _bs.Filter = $"Physician LIKE '%{fldSearch.Text}%'";
            }
            else
            {
                _bs.Filter = $"Patient LIKE '%{fldSearch.Text}%'";
            }

            dgvCalendar.DataSource = _bs;
            
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool _isPhys = true;
            if (radioPatient.Checked)
            {
                _isPhys = false;
            }
            AppointmentSearch(_isPhys);
        }

        private void btnAddNewPhysician_Click(object sender, EventArgs e)
        {
            Form addPhys = new formAddPhysician();
            addPhys.FormClosed += (o, e1) => { updateAppointmentCalendar(); };
            addPhys.ShowDialog();
        }

        private void btnModifyDeletePhysician_Click(object sender, EventArgs e)
        {
            Form modPhys = new formModifyDeletePhysician();
            modPhys.FormClosed += (o, e1) => { updateAppointmentCalendar(); };
            modPhys.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DBConnect.closeConnection();
            this.Close();
            Application.Exit();
        }

        

        private void dgvCalendar_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            dgvCalendar.Sort(dgvCalendar.Columns["Start"], ListSortDirection.Descending);
            _appointment.AppointmentID = 0;
            dgvCalendar.ClearSelection();
        }

        
    }
}
