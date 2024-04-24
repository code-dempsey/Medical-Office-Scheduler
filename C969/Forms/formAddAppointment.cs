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

namespace OfficeScheduler
{
    public partial class formAddAppointment : Form
    {
        public formAddAppointment()
        {
            InitializeComponent();
            loadDGVPatient();
            loadCBPhysician();
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
        private void loadCBPhysician()
        {
            cbPhysician.DataSource = User.PhysicianList().DataSource;
            cbPhysician.DisplayMember = "NameAndSpecialty";     
            cbPhysician.ValueMember = "idphysician";     
            cbPhysician.SelectedIndex = -1;
        }

        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(fldPatient.Text, out int result))
            {
                MessageBox.Show("Please select a patient.");
            }
            else if(cbPhysician.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a physician/specialty.");
            }
            else if(!int.TryParse(fldRoom.Text, out int result1) || (0 >= result1 || result1 > 6)) 
            {
                MessageBox.Show("Please enter a room number between 1 and 6.");
            }
            
            else if(User.VerifyAppointmentTimes(dtpStart.Value, dtpEnd.Value, int.Parse(cbPhysician.SelectedValue.ToString()), int.Parse(fldPatient.Text), 0, fldRoom.Text)) //Why is the appID = 0???? Because it's a new appointment??? 11/21
            {
                try
                {
                    TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
                    TimeSpan estOffset = tzi.GetUtcOffset(dtpStart.Value);


                    DateTime appStartUTC = dtpStart.Value.AddHours(-estOffset.Hours);
                    DateTime appEndUTC = dtpEnd.Value.AddHours(-estOffset.Hours);
                    Appointment appointmentToAdd = new Appointment();

                    appointmentToAdd.PatientID = int.Parse(fldPatient.Text);

                    appointmentToAdd.Room = fldRoom.Text;
                       
                    appointmentToAdd.VisitReason = fldVisitReason.Text;
                    appointmentToAdd.Start = appStartUTC;
                    appointmentToAdd.End = appEndUTC;

                    var patientID = int.Parse(fldPatient.Text);
                    var physicianID = int.Parse(cbPhysician.SelectedValue.ToString());


                    if (cbPhysician.SelectedValue == null)
                    {
                        MessageBox.Show("Please select a physician.");
                    }
                    if (!cbPhysician.Text.Contains(selectedPatient.PatientAgeType()))
                    {
                        MessageBox.Show($"Selected patient is {selectedPatient.PatientAgeType()}. Please select a physician with appropriate specialty.");
                    }

                    else
                    {

                        User.AddAppointment(patientID, physicianID, appStartUTC, appEndUTC, fldVisitReason.Text, fldRoom.Text, User.currentUserID);
                        this.Close();
                    }
                                           
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid data entered." + "\n" + "Please ensure customer is chosen from customer table and user and appointment type are selected.");
                }
            }
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
