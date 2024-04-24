using OfficeScheduler.Database;
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
    public partial class formModifyPatient : Form
    {
        public Patient selectedPatient = new Patient();
        public formModifyPatient()
        {
            InitializeComponent();
            loadDGVPatient();
        }
        private void loadDGVPatient()
        {
            dgvPatient.DataSource = User.PopulatePatientDGV();
            dgvPatient.Columns[0].Visible = false;
            dgvPatient.Columns[1].HeaderText = "Name";
            dgvPatient.Columns[2].HeaderText = "Age";
            dgvPatient.Columns[3].HeaderText = "Address";
            dgvPatient.Columns[4].HeaderText = "Address 2";
            dgvPatient.Columns[5].HeaderText = "City";
            dgvPatient.Columns[6].HeaderText = "State";
            dgvPatient.Columns[7].HeaderText = "Postal";
            dgvPatient.Columns[8].HeaderText = "Phone";
            dgvPatient.Columns[9].HeaderText = "Email";
            dgvPatient.Columns[10].HeaderText = "Insurance ID";
            dgvPatient.Columns[11].HeaderText = "Insurance Group";
            dgvPatient.Columns[12].HeaderText = "SSN";
            dgvPatient.Columns[13].HeaderText = "Allergies";
            dgvPatient.Columns["modifyDate"].Visible = false;
            dgvPatient.Columns["modifiedBy"].Visible = false;
            dgvPatient.Columns["createDate"].Visible = false;
            dgvPatient.Columns["createdBy"].Visible = false;
            dgvPatient.ClearSelection();
        }
        private void clearTextBoxes()
        {
            fldAddress.Clear();
            fldAddress2.Clear();
            fldCity.Clear();
            fldState.Clear();
            fldName.Clear();
            fldAge.Clear();
            fldPhone.Clear();
            fldPostal.Clear();
            fldInsuranceGroup.Clear();
            fldInsuranceID.Clear();
            fldSSN.Clear();
            fldAllergies.Clear();
            fldEmail.Clear();
        }

        //*****Populates Modify/Delete customer form fields with the information of the customer selected in dgvPatient
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
            selectedPatient.Age = (int)dgvPatient.CurrentRow.Cells["age"].Value;
            selectedPatient.PatientID = (int)dgvPatient.CurrentRow.Cells["idpatient"].Value;
            selectedPatient.Address1 = dgvPatient.CurrentRow.Cells["addressline1"].Value.ToString();
            selectedPatient.Address2 = dgvPatient.CurrentRow.Cells["addressline2"].Value.ToString();
            selectedPatient.City = dgvPatient.CurrentRow.Cells["city"].Value.ToString();
            selectedPatient.State = dgvPatient.CurrentRow.Cells["state"].Value.ToString();
            selectedPatient.PostalCode = dgvPatient.CurrentRow.Cells["postalcode"].Value.ToString();
            selectedPatient.Phone = dgvPatient.CurrentRow.Cells["phone"].Value.ToString();
            selectedPatient.Email = dgvPatient.CurrentRow.Cells["email"].Value.ToString();
            selectedPatient.InsuranceID = dgvPatient.CurrentRow.Cells["insuranceid"].Value.ToString();
            selectedPatient.InsuranceGroup = dgvPatient.CurrentRow.Cells["insurancegroup"].Value.ToString();
            selectedPatient.SSN = (int)dgvPatient.CurrentRow.Cells["ssn"].Value;
            selectedPatient.Allergies = dgvPatient.CurrentRow.Cells["allergies"].Value.ToString();

            fldName.Text = selectedPatient.Name;
            fldAge.Text = selectedPatient.Age.ToString();
            fldAddress.Text = selectedPatient.Address1;
            fldAddress2.Text = selectedPatient.Address2;
            fldCity.Text = selectedPatient.City;
            fldState.Text = selectedPatient.State;
            fldPostal.Text = selectedPatient.PostalCode;
            fldPhone.Text = selectedPatient.Phone;
            fldEmail.Text = selectedPatient.Email;
            fldInsuranceID.Text = selectedPatient.InsuranceID;
            fldInsuranceGroup.Text = selectedPatient.InsuranceGroup;
            fldSSN.Text = selectedPatient.SSN.ToString();
            fldAllergies.Text = selectedPatient.Allergies;

            
        }
        delegate bool noData(string fldData);
        noData testNoData = d => d.Length == 0;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(fldPhone.Text, out int result))
            {
                MessageBox.Show("Phone number must be entered in number-only format.");
            }
            else if (!int.TryParse(fldPostal.Text, out int result1))
            {
                MessageBox.Show("Postal code must be entered in number-only format.");

            }
            else if (!int.TryParse(fldAge.Text, out int result2))
            {
                MessageBox.Show("Age must be entered in number-only format.");
            }
            else if (!int.TryParse(fldSSN.Text, out int result3))
            {
                MessageBox.Show("SSN must be entered in number-only format.");
            }
            else if (testNoData(fldName.Text) || testNoData(fldAge.Text) || testNoData(fldAddress.Text) || testNoData(fldCity.Text)
                || testNoData(fldState.Text) || testNoData(fldPhone.Text) || testNoData(fldEmail.Text) || testNoData(fldInsuranceID.Text)
                || testNoData(fldInsuranceGroup.Text) || testNoData(fldSSN.Text))
            {
                MessageBox.Show("Please ensure all necessary patient information is entered.");
            }
            else
            {

                User.ModifyPatient(selectedPatient.PatientID, fldName.Text, int.Parse(fldAge.Text), fldAddress.Text, fldAddress2.Text, fldCity.Text, fldState.Text, fldPostal.Text, 
                    fldPhone.Text, fldEmail.Text, fldInsuranceID.Text, fldInsuranceGroup.Text, int.Parse(fldSSN.Text), fldAllergies.Text, User.currentUserID);

                loadDGVPatient();
                clearTextBoxes();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmDeletion = MessageBox.Show("Are you sure you wish to delete this Patient?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmDeletion == DialogResult.Yes)
            {
                User.DeletePatient(selectedPatient.PatientID);
                loadDGVPatient();
                clearTextBoxes();
            }
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
