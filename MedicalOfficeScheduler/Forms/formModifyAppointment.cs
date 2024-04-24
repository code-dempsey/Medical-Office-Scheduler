using OfficeScheduler.Database;
using OfficeScheduler.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeScheduler
{
    public partial class formModifyAppointment : Form
    {
        
        public formModifyAppointment(int appointmentIDToMod, int physicianID, int patientID, int patientAge)
        {
            
            InitializeComponent();

            setAppointmentInfo(appointmentIDToMod, physicianID, patientID, patientAge);
            loadDGVPatient();
            
        }
        public Patient selectedPatient = new Patient();
        private void loadDGVPatient()
        {
            dgvPatient.DataSource = User.PopulatePatientDGV();
            dgvPatient.Columns[0].Visible = false;
            dgvPatient.Columns[1].HeaderText = "Name";
            dgvPatient.Columns[2].HeaderText = "Age";
            dgvPatient.Columns[3].Visible = false;
            dgvPatient.Columns[4].Visible = false;
            dgvPatient.Columns[5].Visible = false;
            dgvPatient.Columns[6].Visible = false;
            dgvPatient.Columns[7].Visible = false;
            dgvPatient.Columns[8].HeaderText = "Phone";
            dgvPatient.Columns[9].HeaderText = "Email";
            dgvPatient.Columns[10].Visible = false;
            dgvPatient.Columns[11].Visible = false;
            dgvPatient.Columns[12].Visible = false;
            dgvPatient.Columns[13].HeaderText = "Allergies";
            dgvPatient.Columns[14].Visible = false;
            dgvPatient.Columns[15].Visible = false;
            dgvPatient.Columns[16].Visible = false;
            dgvPatient.Columns[17].Visible = false;
            dgvPatient.ClearSelection();
        }

        public void setAppointmentInfo(int appInfoID, int physID, int patientID, int patientAge)
        {
            
            Appointment appointmentToMod = new Appointment();

            appointmentToMod = User.GetAppointmentInfo(appInfoID);
            TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            TimeSpan estOffset = tzi.GetUtcOffset(dtpStart.Value);

            //Combobox Setup
            cbPhysician.DataSource = User.PhysicianList().DataSource;
            cbPhysician.DisplayMember = "NameAndSpecialty";
            cbPhysician.ValueMember = "idphysician";
            cbPhysician.SelectedValue = physID;
           

            selectedPatient.PatientID = patientID;
            selectedPatient.Age = patientAge;
            if (selectedPatient.Age < 18)
            {
                selectedPatient = new PediatricPatient();
            }
            else if (selectedPatient.Age >= 18)
            {
                selectedPatient = new AdultPatient();
            }
            fldPatient.Text = patientID.ToString();
            fldAppointmentID.Text = appointmentToMod.AppointmentID.ToString();          
            fldVisitReason.Text = appointmentToMod.VisitReason;
            fldRoom.Text = appointmentToMod.Room;
            
            dtpStart.Value = appointmentToMod.Start.AddHours(estOffset.Hours);
            dtpEnd.Value = appointmentToMod.End.AddHours(estOffset.Hours);
        }
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            TimeSpan estOffset = tzi.GetUtcOffset(dtpStart.Value);
            if (cbPhysician.SelectedValue == null)
            {
                MessageBox.Show("Please select a physician.");
                return;
            }
            if (!cbPhysician.Text.Contains(selectedPatient.PatientAgeType()))
            {
                MessageBox.Show($"Selected patient is {selectedPatient.PatientAgeType()}. Please select a physician with appropriate specialty.");
                return;
            }
            if (!int.TryParse(fldRoom.Text, out int result1) || (0 >= result1 || result1 > 6))
            {
                MessageBox.Show("Please enter a room number between 1 and 6.");
                return;
            }

            if (User.VerifyAppointmentTimes(dtpStart.Value, dtpEnd.Value, int.Parse(cbPhysician.SelectedValue.ToString()), int.Parse(fldPatient.Text), int.Parse(fldAppointmentID.Text), fldRoom.Text))
            {

                User.ModifyAppointment(int.Parse(fldAppointmentID.Text), int.Parse(fldPatient.Text), int.Parse(cbPhysician.SelectedValue.ToString()), 
                    dtpStart.Value.AddHours(-estOffset.Hours), dtpEnd.Value.AddHours(-estOffset.Hours), fldVisitReason.Text, fldRoom.Text, User.currentUserID);
                this.Close();
            }

        }

        private void dgvPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPatient.CurrentRow.Cells["age"].Value != null && (int)dgvPatient.CurrentRow.Cells["age"].Value < 18)
            {
                selectedPatient = new PediatricPatient();
            }
            else if (dgvPatient.CurrentRow.Cells["age"].Value != null && (int)dgvPatient.CurrentRow.Cells["age"].Value >= 18)
            {
                selectedPatient = new AdultPatient();
            }
            selectedPatient.Name = dgvPatient.CurrentRow.Cells["name"].Value.ToString();
            selectedPatient.PatientID = (int)dgvPatient.CurrentRow.Cells["idpatient"].Value;
            fldPatient.Text = selectedPatient.PatientID.ToString();
            selectedPatient.Age = (int)dgvPatient.CurrentRow.Cells["age"].Value;
        }

        private void dgvPatient_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvPatient.ClearSelection();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
